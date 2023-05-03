using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Data;

public class Hotel
{
    public int Id { get; set; } // Primary Key (PK)
    public string Name { get; set; }
    public string Address { get; set; }

    public double Rating { get; set; }

    [ForeignKey(nameof(CountryId))]
    public int CountryId { get; set; }  // Foreign Key (FK)

    public Country Country { get; set; }
}