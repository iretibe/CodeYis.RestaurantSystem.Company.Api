using MediatR;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetCountryByIdQuery : IRequest<RestaurantSystem.Company.Api.Entities.Country>
    {
        public Guid Id { get; set; }
    }
}
