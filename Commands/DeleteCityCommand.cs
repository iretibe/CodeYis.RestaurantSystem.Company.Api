using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class DeleteCityCommand : IRequest<int>
    {
        public Guid Id { get; set; }
    }
}
