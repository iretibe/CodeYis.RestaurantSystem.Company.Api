using MediatR;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetAllCountriesQuery : IRequest<List<RestaurantSystem.Company.Api.Entities.Country>>
    {
    }
}
