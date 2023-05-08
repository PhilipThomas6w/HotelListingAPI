using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;

namespace HotelListingAPI.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap(); // <source, destination> ... ReverseMap() allows us to map in either direction
            CreateMap<Country, GetCountryDto>().ReverseMap();
        }
    }
}
