using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class UpdateCityCommand : IRequest<int>
    {
        public Guid CityID { get; set; }
        public string CityName { get; set; }
        public Guid CountryID { get; set; }

        public UpdateCityCommand(Guid cityID, string cityName, Guid countryID)
        {
            CityID = cityID;
            CityName = cityName;
            CountryID = countryID;
        }
    }
}
