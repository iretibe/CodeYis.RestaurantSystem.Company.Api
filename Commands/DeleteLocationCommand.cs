using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class DeleteLocationCommand : IRequest<int>
    {
        public Guid Id { get; set; }
    }
}
