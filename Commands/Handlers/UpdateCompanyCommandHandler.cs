using MediatR;
using RestaurantSystem.Company.Api.Repositories;

namespace RestaurantSystem.Company.Api.Commands.Handlers
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, int>
    {
        private readonly ICompanyRepository _companyRepository;

        public UpdateCompanyCommandHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<int> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var model = await _companyRepository.GetCompanyByIdAsync(request.CompanyID);

            if (model == null) return default;

            model.CompanyName = request.CompanyName;
            model.Email = request.Email;
            model.PhoneNo = request.PhoneNo;
            model.FaxNo = request.FaxNo;
            model.CountryID = request.CountryID;
            model.CityID = request.CityID;
            model.LocationID = request.LocationID;
            model.Address = request.Address;
            model.Website = request.Website;
            model.VATNo = request.VATNo;
            model.VATRate = request.VATRate;
            model.NHILRate = request.NHILRate;
            model.CurrencyID = request.CurrencyID;
            model.Logo = request.Logo;
            model.CreatedBy = request.CreatedBy;
            model.CreatedOn = DateTime.UtcNow;

            return await _companyRepository.UpdateCompanyAsync(model);
        }
    }
}
