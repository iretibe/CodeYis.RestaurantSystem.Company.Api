using MediatR;
using RestaurantSystem.Country.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand, int>
    {
        private readonly ICountryRepository _countryRepository;

        public UpdateCountryCommandHandler(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<int> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
        {
            var model = await _countryRepository.GetCountryByIdAsync(request.CountryID);

            if (model == null) return default;

            model.CountryName = request.CountryName;
            model.CountryCode = request.CountryCode;

            return await _countryRepository.UpdateCountryAsync(model);
        }
    }
}
