using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommand, int>
    {
        private readonly ILocationRepository _locationRepository;

        public DeleteLocationCommandHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<int> Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
        {
            var model = await _locationRepository.GetLocationByIdAsync(request.Id);

            if (model == null) return default;

            return await _locationRepository.DeleteLocationAsync(model.LocationID);
        }
    }
}
