using MediatR;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetCurrencyByIdQuery : IRequest<Entities.Currency>
    {
        public Guid Id { get; set; }
    }
}
