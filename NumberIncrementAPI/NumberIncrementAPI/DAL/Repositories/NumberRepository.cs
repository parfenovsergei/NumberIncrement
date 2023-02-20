using NumberIncrementAPI.DAL.Interfaces;
using NumberIncrementAPI.Models;

namespace NumberIncrementAPI.DAL.Repositories
{
    public class NumberRepository : IBaseRepository<Number>
    {
        private readonly ApplicationDbContext _db;
        public NumberRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<Number> GetAll()
        {
            return _db.Numbers;
        }

        public async Task<Number> Update(Number entity)
        {
            _db.Numbers.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
