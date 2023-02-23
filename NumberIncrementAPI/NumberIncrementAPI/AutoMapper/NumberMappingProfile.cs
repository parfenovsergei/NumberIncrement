using AutoMapper;

using NumberIncrementAPI.Models;
using NumberIncrementAPI.ViewModels;

namespace NumberIncrementAPI.AutoMapper
{
    public class NumberMappingProfile : Profile
    {
        public NumberMappingProfile()
        {
            CreateMap<Number, NumberDTO>().ReverseMap();
        }
    }
}
