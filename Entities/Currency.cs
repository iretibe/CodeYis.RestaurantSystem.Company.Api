using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Company.Api.Entities
{
    public class Currency
    {
        [Key]
        public Guid CurrencyID { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrencyName { get; set; }
        [StringLength(3)]
        public string CurrencyCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrencySymbol { get; set; }
    }
}
