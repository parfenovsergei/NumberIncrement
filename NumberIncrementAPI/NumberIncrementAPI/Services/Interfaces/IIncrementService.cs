using NumberIncrementAPI.Models;

namespace NumberIncrementAPI.Services.Interfaces
{
    public interface IIncrementService
    {
        Task<List<Number>> GetAllNumbers();
        Task<Number> UpdateNumber(int id, int increment);
        Task<Number> UpdateDate(int id, DateTime dateTime);
    }
}
