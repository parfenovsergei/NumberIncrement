namespace NumberIncrementAPI.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        Task<T> UpdateAsync(T entity);
    }
}
