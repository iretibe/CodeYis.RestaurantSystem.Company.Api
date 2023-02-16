using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetCurrencyByIdQueryHandler : IRequestHandler<GetCurrencyByIdQuery, Entities.Currency>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetCurrencyByIdQueryHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<Currency> Handle(GetCurrencyByIdQuery request, CancellationToken cancellationToken)
        {
            return await _currencyRepository.GetCurrencyByIdAsync(request.Id);
        }
    }
}
