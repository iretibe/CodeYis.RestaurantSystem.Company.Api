using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, int>
    {
        private readonly ICompanyRepository _companyRepository;

        public DeleteCompanyCommandHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<int> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            var model = await _companyRepository.GetCompanyByIdAsync(request.Id);

            if (model == null) return default;

            return await _companyRepository.DeleteCompanyAsync(model.CityID);
        }
    }
}
