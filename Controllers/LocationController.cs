using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Company.Api.Commands;
using RestaurantSystem.Company.Api.Queries;

namespace RestaurantSystem.Company.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllLocations")]
        public async Task<List<Entities.Location>> GetAllLocations()
        {
            var result = await _mediator.Send(new GetAllLocationsQuery());

            return result;
        }

        [HttpGet("GetLocationsById")]
        public async Task<Entities.Location> GetLocationsById(Guid LocationId)
        {
            var result = await _mediator.Send(new GetLocationByIdQuery() { Id = LocationId });

            return result;
        }

        [HttpPost("PostLocation")]
        public async Task<Entities.Location> PostLocation(Entities.Location model)
        {
            var result = await _mediator.Send(new CreateLocationCommand(model.LocationName, model.IsDefault));

            return result;
        }

        [HttpPut("PutLocation")]
        public async Task<int> PutLocation(Entities.Location model)
        {
            var result = await _mediator.Send(new UpdateLocationCommand(model.LocationID, model.LocationName, model.IsDefault));

            return result;
        }

        [HttpDelete("DeleteLocation")]
        public async Task<int> DeleteLocation(Guid Id)
        {
            return await _mediator.Send(new DeleteLocationCommand() { Id = Id });
        }
    }
}
