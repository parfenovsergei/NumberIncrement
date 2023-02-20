namespace NumberIncrementAPI.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        Task<T> Update(T entity);
    }
}
