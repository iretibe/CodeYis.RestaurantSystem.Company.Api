using MediatR;
using RestaurantSystem.Company.Api.Entities;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetCityByIdQuery : IRequest<City>
    {
        public Guid Id { get; set; }
    }
}
