using Task.Models;
using Task.Models.DtoModels;

namespace Task.Repository
{
    public class ProgramRepository : IProgramRepository
    {
        public ProgramModel Create(ProgramModelDto program)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProgramModelDto>? GetAll()
        {
            throw new NotImplementedException();
        }

        public ProgramModelDto? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, ProgramModelDto t)
        {
            throw new NotImplementedException();
        }
    }
}
