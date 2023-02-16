using MediatR;
using RestaurantSystem.Company.Api.Entities;

namespace RestaurantSystem.Company.Api.Commands
{
    public class CreateCityCommand : IRequest<City>
    {
        public Guid CityID { get; set; }
        public string CityName { get; set; }
        public Guid CountryID { get; set; }

        public CreateCityCommand(string cityName, Guid countryID)
        {
            CityID = Guid.NewGuid();
            CityName = cityName;
            CountryID = countryID;
        }
    }
}
