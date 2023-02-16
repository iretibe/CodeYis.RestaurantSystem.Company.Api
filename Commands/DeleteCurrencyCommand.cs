using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class DeleteCurrencyCommand : IRequest<int>
    {
        public Guid Id { get; set; }
    }
}
