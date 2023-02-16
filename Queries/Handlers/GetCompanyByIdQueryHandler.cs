using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Queries.Handlers
{
    public class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, Entities.Company>
    {
        private readonly ICompanyRepository _companyReposiyory;

        public GetCompanyByIdQueryHandler(ICompanyRepository companyRepository)
        {
            _companyReposiyory = companyRepository;
        }

        public async Task<Entities.Company> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
        {
            return await _companyReposiyory.GetCompanyByIdAsync(request.Id);
        }
    }
}
