using Task.Models;

namespace Task.Repository
{
    public class ApplicationFormRepository : IBaseRepository<ApplicationForm>
    {
        public IEnumerable<ApplicationForm>? GetAll()
        {
            throw new NotImplementedException();
        }

        public ApplicationForm? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, ApplicationForm t)
        {
            throw new NotImplementedException();
        }

        public Section GetSectionByName(string sectionName)
        {
            throw new NotImplementedException();
        }
    }

}
