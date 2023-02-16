using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class CreateCountryCommand : IRequest<RestaurantSystem.Company.Api.Entities.Country>
    {
        public Guid CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public CreateCountryCommand(string countryName, string countryCode)
        {
            CountryID = Guid.NewGuid();
            CountryName = countryName;
            CountryCode = countryCode;
        }
    }
}
