using Microsoft.EntityFrameworkCore;

using NumberIncrementAPI.DAL.Interfaces;
using NumberIncrementAPI.Models;
using NumberIncrementAPI.Services.Interfaces;

namespace NumberIncrementAPI.Services.Implementations
{
    public class IncrementService : IIncrementService
    {
        private readonly IBaseRepository<Number> _numberRepository;
        
        public IncrementService(IBaseRepository<Number> numberRepository)
        {
            _numberRepository = numberRepository;
        }

        public async Task<List<Number>> GetAllNumbers()
        {
            var numbers = await _numberRepository.GetAll().ToListAsync();
            return numbers;
        }
    }
}
