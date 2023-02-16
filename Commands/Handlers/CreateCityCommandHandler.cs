using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, City>
    {
        private readonly ICityRepository _cityRepository;

        public CreateCityCommandHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<City> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var model = new City()
            {
                CityName = request.CityName,
                CountryID = request.CountryID
            };

            return await _cityRepository.AddCityAsync(model);
        }
    }
}
