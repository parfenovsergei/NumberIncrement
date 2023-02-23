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
        public async Task<Number> UpdateDate(int id, DateTime dateTime)
        {
            var number = await _numberRepository.GetAll().FirstOrDefaultAsync(n => n.Id == id);
            if (number != null)
            {
                number.DateFromFront = dateTime;
                var newNumber = await _numberRepository.Update(number);
                return await _numberRepository.Update(newNumber);
            }
            return null;
        }

        public async Task<Number> UpdateNumber(int id, int increment)
        {
            var number = await _numberRepository.GetAll().FirstOrDefaultAsync(n => n.Id == id);
            if (number != null)
            {
                number.CurrentNumber += increment;
                number.LastUpdateDate = DateTime.Now;
                var newNumber = await _numberRepository.Update(number);
                return await _numberRepository.Update(newNumber);
            }
            return null;
        }
    }
}
