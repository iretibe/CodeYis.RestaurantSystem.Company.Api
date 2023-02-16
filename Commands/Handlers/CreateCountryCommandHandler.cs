using MediatR;
using RestaurantSystem.Country.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, Entities.Country>
    {
        private readonly ICountryRepository _countryRepository;

        public CreateCountryCommandHandler(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<Entities.Country> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            var model = new Entities.Country()
            {
                CountryName = request.CountryName,
                CountryCode = request.CountryCode
            };

            return await _countryRepository.AddCountryAsync(model);
        }
    }
}
