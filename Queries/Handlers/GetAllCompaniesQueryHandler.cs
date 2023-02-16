using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, List<Entities.Company>>
    {
        private readonly ICompanyRepository _companyRepository;

        public GetAllCompaniesQueryHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<List<Entities.Company>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
        {
            return await _companyRepository.GetAllCompaniesAsync();
        }
    }
}
