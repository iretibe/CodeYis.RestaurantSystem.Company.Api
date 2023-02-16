using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, City>
    {
        private readonly ICityRepository _cityRepository;

        public GetCityByIdQueryHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<City> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            return await _cityRepository.GetCityByIdAsync(request.Id);
        }
    }
}
