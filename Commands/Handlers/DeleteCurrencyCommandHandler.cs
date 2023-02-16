using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class DeleteCurrencyCommandHandler : IRequestHandler<DeleteCurrencyCommand, int>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public DeleteCurrencyCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<int> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
        {
            var model = await _currencyRepository.GetCurrencyByIdAsync(request.Id);

            if (model == null) return default;

            return await _currencyRepository.DeleteCurrencyAsync(model.CurrencyID);
        }
    }
}
