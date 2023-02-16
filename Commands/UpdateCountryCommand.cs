using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class UpdateCountryCommand : IRequest<int>
    {
        public Guid CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public UpdateCountryCommand(Guid countryID, string countryName, string countryCode)
        {
            CountryID = countryID;
            CountryName = countryName;
            CountryCode = countryCode;
        }
    }
}
