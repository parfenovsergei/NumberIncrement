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

        [HttpGet("Numbers")]
        public async Task<List<NumberDTO>> GetNumbers()
        {
            var numbers = await _incrementService.GetAllNumbers();
            var numbersDTO = _mapper.Map<List<NumberDTO>>(numbers);
            return numbersDTO;
        }

        [HttpPut("IncrementationAsync/{id}")]
        public async Task<List<NumberDTO>> IncrementNumberAsync(int id, [FromBody] int increment)
        {
            var updatedNumber = await _incrementService.UpdateNumber(id, increment);
            return await GetNumbers();
        }

        [HttpPut("ÜpdateDateAsync/{id}")]
        public async Task<List<NumberDTO>> UpdateDateAsync(int id, [FromBody] DateTime dateTime)
        {
            var updatedNumber = await _incrementService.UpdateDate(id, dateTime);
            return await GetNumbers();
        }
    }
}
