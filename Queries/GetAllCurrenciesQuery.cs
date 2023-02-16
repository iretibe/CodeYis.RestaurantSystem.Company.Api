using MediatR;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetAllCurrenciesQuery : IRequest<List<RestaurantSystem.Company.Api.Entities.Currency>>
    {
    }
}
