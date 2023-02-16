using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Company.Api.Commands;
using RestaurantSystem.Company.Api.Queries;

namespace RestaurantSystem.Company.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCompanies")]
        public async Task<List<Entities.Company>> GetAllCompanies()
        {
            var result = await _mediator.Send(new GetAllCompaniesQuery());

            return result;
        }

        [HttpGet("GetCompaniesById")]
        public async Task<Entities.Company> GetCompaniesById(Guid CompanyId)
        {
            var result = await _mediator.Send(new GetCompanyByIdQuery() { Id = CompanyId });

            return result;
        }

        [HttpPost("PostCompany")]
        public async Task<Entities.Company> PostCompany(Entities.Company model)
        {
            var result = await _mediator.Send(new CreateCompanyCommand(model.CompanyName, model.Email, model.PhoneNo,
                model.FaxNo, model.CountryID, model.CityID, model.LocationID, model.Address, model.Website, model.VATNo,
                model.VATRate, model.NHILRate, model.CurrencyID, model.Logo, model.CreatedBy));

            return result;
        }

        [HttpPut("PutCompany")]
        public async Task<int> PutCompany(Entities.Company model)
        {
            var result = await _mediator.Send(new UpdateCompanyCommand(model.CompanyID, model.CompanyName, model.Email, 
                model.PhoneNo, model.FaxNo, model.CountryID, model.CityID, model.LocationID, model.Address, model.Website, 
                model.VATNo, model.VATRate, model.NHILRate, model.CurrencyID, model.Logo, model.CreatedBy));

            return result;
        }

        [HttpDelete("DeleteCompany")]
        public async Task<int> DeleteCompany(Guid Id)
        {
            return await _mediator.Send(new DeleteCompanyCommand() { Id = Id });
        }
    }
}
