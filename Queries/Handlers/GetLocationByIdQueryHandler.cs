using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, Entities.Location>
    {
        private readonly ILocationRepository _locationRepository;

        public GetLocationByIdQueryHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<Location> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            return await _locationRepository.GetLocationByIdAsync(request.Id);
        }
    }
}
