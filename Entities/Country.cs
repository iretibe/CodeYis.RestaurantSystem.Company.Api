using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Company.Api.Entities
{
    public class Country
    {
        [Key]
        public Guid CountryID { get; set; }
        [Required]
        [StringLength(200)]
        public string CountryName { get; set; }
        [StringLength(50)]
        public string CountryCode { get; set; }
    }
}
