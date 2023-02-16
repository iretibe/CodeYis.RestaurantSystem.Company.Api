using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, int>
    {
        private readonly ILocationRepository _locationRepository;

        public UpdateLocationCommandHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<int> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var model = await _locationRepository.GetLocationByIdAsync(request.LocationID);

            if (model == null) return default;

            model.LocationID = request.LocationID;

            return await _locationRepository.UpdateLocationAsync(model);
        }
    }
}
