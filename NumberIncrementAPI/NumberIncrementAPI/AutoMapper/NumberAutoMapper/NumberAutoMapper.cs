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
                .ForMember("CurrentNumber", opt => opt.MapFrom(n => n.CurrentNumber)));

            var mapper = new Mapper(config);

            List<NumberDTO> readMeetups = mapper.Map<List<Number>, List<NumberDTO>>(numbers);

            return readMeetups;
        }
    }
}
