using NumberIncrementAPI.Models;
using NumberIncrementAPI.ViewModels;

namespace NumberIncrementAPI.AutoMapper.NumberAutoMapper
{
    public interface INumberAutoMapper
    {
        public List<NumberDTO> ToDTO(List<Number> numbers); 
    }
}
