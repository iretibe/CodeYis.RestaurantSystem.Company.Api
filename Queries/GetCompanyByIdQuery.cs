using MediatR;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetCompanyByIdQuery : IRequest<RestaurantSystem.Company.Api.Entities.Company>
    {
        public Guid Id { get; set; }
    }
}
