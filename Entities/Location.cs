using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Company.Api.Entities
{
    public class Location
    {
        [Key]
        public Guid LocationID { get; set; }
        [Required]
        [StringLength(50)]
        public string LocationName { get; set; }
        public bool IsDefault { get; set; }
    }
}
