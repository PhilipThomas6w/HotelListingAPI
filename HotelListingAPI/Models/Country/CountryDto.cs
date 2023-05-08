using Microsoft.Build.Framework;

namespace HotelListingAPI.Models.Country;

public class CountryDto
{
    
    [Required]
    public string Name { get; set; }
    public string ShortName { get; set; }

}