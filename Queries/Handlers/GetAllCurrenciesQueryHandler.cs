using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetAllCurrenciesQueryHandler : IRequestHandler<GetAllCurrenciesQuery, List<Entities.Currency>>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetAllCurrenciesQueryHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<List<Currency>> Handle(GetAllCurrenciesQuery request, CancellationToken cancellationToken)
        {
            return await _currencyRepository.GetAllCurrenciesAsync();
        }
    }
}
