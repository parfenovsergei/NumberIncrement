using NumberIncrementAPI.Models;

namespace NumberIncrementAPI.Services.Interfaces
{
    public interface IIncrementService
    {
        Task<List<Number>> GetAllNumbers();
    }
}
