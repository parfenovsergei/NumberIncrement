using AutoMapper;
using NumberIncrementAPI.Models;
using NumberIncrementAPI.ViewModels;

namespace NumberIncrementAPI.AutoMapper.NumberAutoMapper
{
    public class NumberAutoMapper : INumberAutoMapper
    {
        public List<NumberDTO> ToDTO(List<Number> numbers)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Number, NumberDTO>()
                .ForMember("Id", opt => opt.MapFrom(n => n.Id))
                .ForMember("CurrentNumber", opt => opt.MapFrom(n => n.CurrentNumber))
                .ForMember("DateFromFront", opt => opt.MapFrom(n => n.DateFromFront)));
            var mapper = new Mapper(config);

            List<NumberDTO> readNumbers = mapper.Map<List<Number>, List<NumberDTO>>(numbers);

            return readNumbers;
        }
    }
}
