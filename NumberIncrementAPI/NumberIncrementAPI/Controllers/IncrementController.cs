using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using NumberIncrementAPI.AutoMapper.NumberAutoMapper;
using NumberIncrementAPI.Models;
using NumberIncrementAPI.Services.Interfaces;
using NumberIncrementAPI.ViewModels;

namespace NumberIncrementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncrementController : Controller
    {
        private readonly IIncrementService _incrementService;
        private readonly INumberAutoMapper _numberAutoMapper;

        public IncrementController(IIncrementService incrementService, INumberAutoMapper numberAutoMapper)
        {
            _incrementService = incrementService;
            _numberAutoMapper = numberAutoMapper;
        }

        [HttpGet("Numbers")]
        public async Task<List<NumberDTO>> GetNumbers()
        {
            var numbers = await _incrementService.GetAllNumbers();

            var numbersDTO = _numberAutoMapper.ToDTO(numbers);

            return numbersDTO;

        }

        [HttpPut("Incrementation/{id}")]
        public async Task<List<NumberDTO>> IncrementNumber(int id, [FromBody] int increment)
        {
            var updatedNumber = await _incrementService.UpdateNumber(id, increment);

            return await GetNumbers();
        }

        [HttpPut("ÜpdateDate /{id}")]
        public async Task<List<NumberDTO>> UpdateDate(int id, [FromBody] DateTime dateTime)
        {
            var updatedNumber = await _incrementService.UpdateDate(id, dateTime);

            return await GetNumbers();
        }
    }
}
