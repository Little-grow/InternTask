using Task.Models.DtoModels;
using Task.Models;

namespace Task.Repository
{
    public interface IProgramRepository: IBaseRepository<ProgramModelDto> 
    {
        ProgramModel Create(ProgramModelDto program);
    }
}
