using MediatR;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetAllLocationsQuery : IRequest<List<RestaurantSystem.Company.Api.Entities.Location>>
    {
    }
}
