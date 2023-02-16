using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class UpdateCurrencyCommandHandler : IRequestHandler<UpdateCurrencyCommand, int>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public UpdateCurrencyCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<int> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
        {
            var model = await _currencyRepository.GetCurrencyByIdAsync(request.CurrencyID);

            if (model == null) return default;

            model.CurrencyName = request.CurrencyName;
            model.CurrencyCode = request.CurrencyCode;
            model.CurrencySymbol = request.CurrencySymbol;

            return await _currencyRepository.UpdateCurrencyAsync(model);
        }
    }
}
