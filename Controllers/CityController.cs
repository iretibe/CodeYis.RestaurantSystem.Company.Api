using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Company.Api.Commands;
using RestaurantSystem.Company.Api.Entities;
using RestaurantSystem.Company.Api.Queries;

namespace RestaurantSystem.Company.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCities")]
        public async Task<List<City>> GetAllCities()
        {
            var result = await _mediator.Send(new GetAllCitiesQuery());

            return result;
        }

        [HttpGet("GetCitiesById")]
        public async Task<City> GetCitiesById(Guid cityId)
        {
            var result = await _mediator.Send(new GetCityByIdQuery() { Id = cityId });

            return result;
        }

        [HttpPost("PostCity")]
        public async Task<City> PostCity(City model)
        {
            var result = await _mediator.Send(new CreateCityCommand(model.CityName, model.CountryID));

            return result;
        }

        [HttpPut("PutCity")]
        public async Task<int> PutCity(City model)
        {
            var result = await _mediator.Send(new UpdateCityCommand(model.CityID, model.CityName, model.CountryID));

            return result;
        }

        [HttpDelete("DeleteCity")]
        public async Task<int> DeleteCity(Guid Id)
        {
            return await _mediator.Send(new DeleteCityCommand() { Id = Id });
        }
    }
}
