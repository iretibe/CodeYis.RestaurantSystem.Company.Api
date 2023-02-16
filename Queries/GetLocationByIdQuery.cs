using MediatR;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetLocationByIdQuery : IRequest<RestaurantSystem.Company.Api.Entities.Location>
    {
        public Guid Id { get; set; }
    }
}
