using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Company.Api.Entities
{
    public class City
    {
        [Key]
        public Guid CityID { get; set; }
        [Required]
        [StringLength(50)]
        public string CityName { get; set; }
        public Guid CountryID { get; set; }
    }
}
