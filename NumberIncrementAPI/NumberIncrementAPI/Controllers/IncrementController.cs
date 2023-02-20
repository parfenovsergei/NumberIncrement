using Microsoft.AspNetCore.Mvc;

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
    }
}
