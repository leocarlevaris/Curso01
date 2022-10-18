using AutoMapper;
using Curso01.Data;
using Curso01.Models.Country;

namespace Curso01.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
        }
    }
}
