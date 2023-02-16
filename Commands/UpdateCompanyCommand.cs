using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class UpdateCompanyCommand : IRequest<int>
    {
        public Guid CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public Guid CountryID { get; set; }
        public Guid CityID { get; set; }
        public Guid LocationID { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string VATNo { get; set; }
        public double VATRate { get; set; }
        public double NHILRate { get; set; }
        public Guid CurrencyID { get; set; }
        public string Logo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public UpdateCompanyCommand(Guid companyID, string companyName, string email, string phoneNo, string faxNo,
            Guid countryID, Guid cityID, Guid locationID, string address, string website, string vatNo, double vatRate, 
            double nhilRate, Guid currencyID, string logo, string createdBy)
        {
            CompanyID = companyID;
            CompanyName = companyName;
            Email = email;
            PhoneNo = phoneNo;
            FaxNo = faxNo;
            CountryID = countryID;
            CityID = cityID;
            LocationID = locationID;
            Address = address;
            Website = website;
            VATNo = vatNo;
            VATRate = vatRate;
            NHILRate = nhilRate;
            CurrencyID = currencyID;
            Logo = logo;
            CreatedBy = createdBy;
            CreatedOn = DateTime.Now;
        }
    }
}
