using MediatR;
using RestaurantSystem.Company.Api.Entities;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetAllCitiesQuery : IRequest<List<City>>
    {
    }
}
