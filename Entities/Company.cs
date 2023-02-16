using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Company.Api.Entities
{
    public class Company
    {
        [Key]
        public Guid CompanyID { get; set; }
        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(100)]
        public string PhoneNo { get; set; }
        [StringLength(100)]
        public string FaxNo { get; set; }
        public Guid CountryID { get; set; }
        public Country Country { get; set; }
        public Guid CityID { get; set; }
        public City City { get; set; }
        public Guid LocationID { get; set; }
        public Location Location { get; set; }
        public string Address { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
        [StringLength(50)]
        public string VATNo { get; set; }
        public double VATRate { get; set; }
        public double NHILRate { get; set; }
        public Guid CurrencyID { get; set; }
        public Currency Currency { get; set; }
        public string Logo { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
