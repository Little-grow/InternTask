using Microsoft.AspNetCore.Mvc;
using Task.Models;
using Task.Repository;

namespace Task.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsFormController : ControllerBase
    {
        private readonly IBaseRepository<ApplicationForm> _applicationFormRepository;
        private readonly IQuestionRepository _questionRepository;

        public ApplicationsFormController(IBaseRepository<ApplicationForm> repository, IQuestionRepository questionRepository)
        {
            _applicationFormRepository = repository;
            _questionRepository = questionRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<ApplicationForm> Get(int id)
        {
            var template = _applicationFormRepository.GetById(id);
            
            if (template == null)
            {
                return NotFound();
            }

            return Ok(template);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ApplicationForm updatedForm)
        {
            var existingFrom = _applicationFormRepository.GetById(id);
          
            if (existingFrom == null)
            {
                return NotFound();
            }
            existingFrom.UploadCoverLetter = updatedForm.UploadCoverLetter;
            existingFrom.AdditionalQuestions = updatedForm.AdditionalQuestions; 
            existingFrom.PersonalInformation = updatedForm.PersonalInformation;
            existingFrom.Profile = updatedForm.Profile;

            return NoContent();
        }

        [HttpPost("{id}/{sectionName}/addQuestion")]
        public IActionResult AddQuestionToSection(int id, string sectionName, [FromBody] Question question)
        {
            // Get the application template by id
            var template = _applicationFormRepository.GetById(id);
            if (template == null)
            {
                return NotFound();
            }

            // Find the section by name
            var section = template.GetSectionByName(sectionName);
            if (section == null)
            {
                return NotFound();
            }

            // Add the question to the section
            section.AddQuestion(_questionRepository,sectionName,question);

            _applicationFormRepository.Update(id,template);
            return Ok(template);
        }

        [HttpPost("{id}/{Profile}/addWorkExperience")]
        public IActionResult AddWorkExperience(int id,Experience experience ) 
        {
            var template = _applicationFormRepository.GetById(id);
            if (template == null)
            {
                return NotFound();
            }

            var profile = template.GetSectionByName("Profile") as ProfileSection;
            if (profile?.Experience == null)
            {
                profile.Experience = new List<Experience> { experience };
            }
            profile.Experience.Add(experience);
            return NoContent();
        }

        [HttpPost("{id}/{Profile}/addEducation")]
        public IActionResult AddEducation (int id,Education education)
        {
            // same logic as AddAddWorkExperience
            var template = _applicationFormRepository.GetById(id);
            if (template == null)
            {
                return NotFound();
            }

            var profile = template.GetSectionByName("Profile") as ProfileSection;
            if (profile?.Education == null)
            {
                profile.Education = new List<Education> { education };
            }

            profile.Education.Add(education);
            return NoContent();
        }
    }
}
