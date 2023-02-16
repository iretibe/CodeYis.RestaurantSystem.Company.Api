using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, Entities.Company>
    {
        private readonly ICompanyRepository _companyRepository;

        public CreateCompanyCommandHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<Entities.Company> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var model = new Entities.Company()
            {
                CompanyName = request.CompanyName,
                Email = request.Email,
                PhoneNo = request.PhoneNo,
                FaxNo = request.FaxNo,
                CountryID = request.CountryID,
                CityID = request.CityID,
                LocationID = request.LocationID,
                Address = request.Address,
                Website = request.Website,
                VATNo = request.VATNo,
                VATRate = request.VATRate,
                NHILRate = request.NHILRate,
                CurrencyID = request.CurrencyID,
                Logo = request.Logo,
                CreatedBy = request.CreatedBy,
                CreatedOn = DateTime.UtcNow,
            };

            return await _companyRepository.AddCompanyAsync(model);
        }
    }
}
