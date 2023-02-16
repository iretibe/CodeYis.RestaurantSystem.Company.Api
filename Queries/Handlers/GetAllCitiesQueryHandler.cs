using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, List<City>>
    {
        private readonly ICityRepository _cityRepository;

        public GetAllCitiesQueryHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<List<City>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
        {
            return await _cityRepository.GetAllCitiesAsync();
        }
    }
}
