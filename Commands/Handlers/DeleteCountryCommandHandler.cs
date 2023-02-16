using MediatR;
using RestaurantSystem.Country.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand, int>
    {
        private readonly ICountryRepository _countryRepository;

        public DeleteCountryCommandHandler(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<int> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
        {
            var model = await _countryRepository.GetCountryByIdAsync(request.Id);

            if (model == null) return default;

            return await _countryRepository.DeleteCountryAsync(model.CountryID);
        }
    }
}
