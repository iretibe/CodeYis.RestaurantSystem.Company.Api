using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, int>
    {
        private readonly ICityRepository _cityRepository;

        public UpdateCityCommandHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<int> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
        {
            var model = await _cityRepository.GetCityByIdAsync(request.CityID);

            if (model == null) return default;

            model.CityName = request.CityName;
            model.CountryID = request.CountryID;

            return await _cityRepository.UpdateCityAsync(model);
        }
    }
}
