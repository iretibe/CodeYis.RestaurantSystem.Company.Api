using MediatR;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand, Entities.Currency>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CreateCurrencyCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<Currency> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
        {
            var model = new Entities.Currency()
            {
                CurrencyName = request.CurrencyName,
                CurrencyCode = request.CurrencyCode,
                CurrencySymbol = request.CurrencySymbol
            };

            return await _currencyRepository.AddCurrencyAsync(model);
        }
    }
}
