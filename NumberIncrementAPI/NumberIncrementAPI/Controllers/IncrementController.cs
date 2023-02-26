using AutoMapper;
using Microsoft.AspNetCore.Mvc;

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
        private readonly IMapper _mapper;

        public IncrementController(IIncrementService incrementService, IMapper mapper)
        {
            _incrementService = incrementService;
            _mapper = mapper;
        }

        [HttpGet("numbers")]
        public async Task<List<NumberDTO>> GetNumbersAsync()
        {
            var numbers = await _incrementService.GetAllNumbersAsync();
            var numbersDTO = _mapper.Map<List<NumberDTO>>(numbers);
            return numbersDTO;
        }

        [HttpPut("numbers/{id}")]
        public async Task<List<NumberDTO>> IncrementNumberAsync(int id, [FromBody] int increment)
        {
            var updatedNumber = await _incrementService.UpdateNumberAsync(id, increment);
            return await GetNumbersAsync();
        }

        [HttpPut("dates/{id}")]
        public async Task<List<NumberDTO>> UpdateDateAsync(int id, [FromBody] DateTime dateTime)
        {
            var updatedNumber = await _incrementService.UpdateDateAsync(id, dateTime);
            return await GetNumbersAsync();
        }
    }
}
