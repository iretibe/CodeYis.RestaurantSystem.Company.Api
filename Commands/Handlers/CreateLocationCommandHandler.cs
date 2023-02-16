using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand, Entities.Location>
    {
        private readonly ILocationRepository _locationRepository;

        public CreateLocationCommandHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<Location> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var model = new Entities.Location()
            {
                LocationName = request.LocationName,
                IsDefault = request.IsDefault
            };

            return await _locationRepository.AddLocationAsync(model);
        }
    }
}
