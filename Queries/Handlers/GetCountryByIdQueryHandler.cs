using MediatR;
using RestaurantSystem.Country.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetCountryByIdQueryHandler : IRequestHandler<GetCountryByIdQuery, Entities.Country>
    {
        private readonly ICountryRepository _countryRepository;

        public GetCountryByIdQueryHandler(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<Entities.Country> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
        {
            return await _countryRepository.GetCountryByIdAsync(request.Id);
        }
    }
}
