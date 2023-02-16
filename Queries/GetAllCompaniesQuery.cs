using MediatR;

namespace RestaurantSystem.Company.Api.Queries
{
    public class GetAllCompaniesQuery : IRequest<List<Entities.Company>>
    {
    }
}
