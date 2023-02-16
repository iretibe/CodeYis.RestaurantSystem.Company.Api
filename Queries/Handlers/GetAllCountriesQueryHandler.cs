using MediatR;
using RestaurantSystem.Country.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesQuery, List<Entities.Country>>
    {
        private readonly ICountryRepository _countryRepository;

        public GetAllCountriesQueryHandler(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<List<Entities.Country>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            return await _countryRepository.GetAllCountriesAsync();
        }
    }
}
