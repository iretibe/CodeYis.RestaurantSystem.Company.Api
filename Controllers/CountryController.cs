using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Company.Api.Commands;
using RestaurantSystem.Company.Api.Queries;

namespace RestaurantSystem.Company.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCountries")]
        public async Task<List<Entities.Country>> GetAllCountries()
        {
            var result = await _mediator.Send(new GetAllCountriesQuery());

            return result;
        }

        [HttpGet("GetCountriesById")]
        public async Task<Entities.Country> GetCountriesById(Guid CountryId)
        {
            var result = await _mediator.Send(new GetCountryByIdQuery() { Id = CountryId });

            return result;
        }

        [HttpPost("PostCountry")]
        public async Task<Entities.Country> PostCountry(Entities.Country model)
        {
            var result = await _mediator.Send(new CreateCountryCommand(model.CountryName, model.CountryCode));

            return result;
        }

        [HttpPut("PutCountry")]
        public async Task<int> PutCountry(Entities.Country model)
        {
            var result = await _mediator.Send(new UpdateCountryCommand(model.CountryID, model.CountryName, model.CountryCode));

            return result;
        }

        [HttpDelete("DeleteCountry")]
        public async Task<int> DeleteCountry(Guid Id)
        {
            return await _mediator.Send(new DeleteCountryCommand() { Id = Id });
        }
    }
}
