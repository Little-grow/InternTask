using Microsoft.AspNetCore.Mvc;
using Task.Models.DtoModels;
using Task.Repository;

namespace Task.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgramsController : ControllerBase
    {
        private readonly IProgramRepository _programRepository;

        public ProgramsController(IProgramRepository repository)
        {
            _programRepository = repository;
        }

        [HttpGet(Name ="programs")]
        public IActionResult GetAllPrograms()
        {
            var programs = _programRepository.GetAll();
            return Ok(programs);
        }

        [HttpGet("{id}", Name = "DisplayProgram")]
        public IActionResult Get(int id)
        {
            var program = _programRepository.GetById(id);

            if (program == null)
            {
                return NotFound();
            }

            return Ok(program);
        }

        [HttpPost("programs")]
        public IActionResult CreateProgram ([FromBody] ProgramModelDto program)
        {
            // Validate and create the program using the repository
            var createdProgram = _programRepository.Create(program);

            return Ok(createdProgram);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProgramModelDto updatedProgram)
        {
            var existingProgram = _programRepository.GetById(id);

            if (existingProgram == null)
            {
                return NotFound();
            }

            _programRepository.Update(id, updatedProgram);

            return NoContent();
        }
    }
}
