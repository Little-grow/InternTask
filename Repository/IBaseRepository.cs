namespace Task.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T>? GetAll();
        T? GetById(int id);
        void Update(int id, T t);
    }
}

