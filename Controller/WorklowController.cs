using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Task.Models.DtoModels;
using Task.Repository;

namespace Task.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowController : ControllerBase
    {
        private readonly IBaseRepository<WorkflowDto> _workflowService;

        public WorkflowController(IBaseRepository<WorkflowDto> workflowService)
        {
            _workflowService = workflowService;
        }

        [HttpGet("{workflowId}")]
        public IActionResult GetWorkflow(int workflowId)
        {
            var workflow = _workflowService.GetById(workflowId);

            if (workflow == null)
            {
                return NotFound();
            }

            return Ok(workflow);
        }

        [HttpPut("{workflowId}")]
        public IActionResult UpdateWorkflow(int workflowId, [FromBody] WorkflowDto workflowDto)
        {
            _workflowService.Update(workflowId, workflowDto);
            return NoContent();
        }

    }
}
