using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetAllLocationsQueryHandler : IRequestHandler<GetAllLocationsQuery, List<Location>>
    {
        private readonly ILocationRepository _locationRepository;

        public GetAllLocationsQueryHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<List<Location>> Handle(GetAllLocationsQuery request, CancellationToken cancellationToken)
        {
            return await _locationRepository.GetAllLocationsAsync();
        }
    }
}
