using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class DeleteCompanyCommand : IRequest<int>
    {
        public Guid Id { get; set; }
    }
}
