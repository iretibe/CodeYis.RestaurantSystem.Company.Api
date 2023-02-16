using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, int>
    {
        private readonly ICityRepository _cityRepository;

        public DeleteCityCommandHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<int> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            var model = await _cityRepository.GetCityByIdAsync(request.Id);

            if (model == null) return default;

            return await _cityRepository.DeleteCityAsync(model.CityID);
        }
    }
}
