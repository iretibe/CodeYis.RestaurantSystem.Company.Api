using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class DeleteCountryCommand : IRequest<int>
    {
        public Guid Id { get; set; }
    }
}
