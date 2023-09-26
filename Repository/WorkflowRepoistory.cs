using Task.Models;
using Task.Models.DtoModels;

namespace Task.Repository
{
    public class WorkflowRepository: IBaseRepository<WorkflowDto>
    {
        private readonly CosmosDbClient _context;
        public WorkflowRepository(CosmosDbClient context)
        {
            _context = context;
        }
        public IEnumerable<WorkflowDto> GetAll()
        {
            throw new NotImplementedException();
           // return _context.Workflows;
        }
        public WorkflowDto GetById(int id)
        {
            throw new NotImplementedException();
            //return _context.Workflows.Find(id);
        }
        public void Update(int id, WorkflowDto workflowDto)
        {
            throw new NotImplementedException();
            //var workflow = _context.Workflows.Find(id);
            //workflow.Stage.Clear();
            //foreach (var stage in workflowDto.Stage)
            //{
            //    workflow.Stage.Add(stage);
            //}
        }
    }
}
