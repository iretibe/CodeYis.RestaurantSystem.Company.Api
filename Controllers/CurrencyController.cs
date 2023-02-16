using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Company.Api.Commands;
using RestaurantSystem.Company.Api.Queries;

namespace RestaurantSystem.Company.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CurrencyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCurrencies")]
        public async Task<List<Entities.Currency>> GetAllCurrencies()
        {
            var result = await _mediator.Send(new GetAllCurrenciesQuery());

            return result;
        }

        [HttpGet("GetCurrenciesById")]
        public async Task<Entities.Currency> GetCurrenciesById(Guid CurrencyId)
        {
            var result = await _mediator.Send(new GetCurrencyByIdQuery() { Id = CurrencyId });

            return result;
        }

        [HttpPost("PostCurrency")]
        public async Task<Entities.Currency> PostCurrency(Entities.Currency model)
        {
            var result = await _mediator.Send(new CreateCurrencyCommand(model.CurrencyName, model.CurrencyCode, model.CurrencySymbol));

            return result;
        }

        [HttpPut("PutCurrency")]
        public async Task<int> PutCurrency(Entities.Currency model)
        {
            var result = await _mediator.Send(new UpdateCurrencyCommand(model.CurrencyID, model.CurrencyName, model.CurrencyCode, model.CurrencySymbol));

            return result;
        }

        [HttpDelete("DeleteCurrency")]
        public async Task<int> DeleteCurrency(Guid Id)
        {
            return await _mediator.Send(new DeleteCurrencyCommand() { Id = Id });
        }
    }
}
