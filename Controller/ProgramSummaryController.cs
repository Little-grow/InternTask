using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Task.Models.DtoModels;
using Task.Repository;

namespace Task.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramSummaryController : ControllerBase
    {
        private readonly IProgramRepository _programRepository;
        public ProgramSummaryController(IProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }

        [HttpGet("preview/{programId}")]
        public IActionResult GetProgramPreview(int programId)
        {
            // Retrieve the program and related data from your data store
            var program = _programRepository.GetById(programId);

            if (program == null)
            {
                return NotFound();
            }

            var programSummary = new ProgramSummaryDto
            {
                ProgramTitle = program.ProgramTitle,
                ProgramDescription = program.ProgramDescription,
                ProgramBenefits = program.ProgramBenefits,
                ProgramSkills = program.ProgramSkills,
                ProgramSummary = program.ProgramSummary,
                ApplicationCriteria = program.ApplicationCriteria,
            };
            return Ok(programSummary);
        }

    }
}
