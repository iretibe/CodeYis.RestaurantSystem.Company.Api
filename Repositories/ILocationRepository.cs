namespace RestaurantSystem.Company.Api.Repositories
{
    public interface ILocationRepository
    {
        Task<List<RestaurantSystem.Company.Api.Entities.Location>> GetAllLocationsAsync();
        Task<RestaurantSystem.Company.Api.Entities.Location> GetLocationByIdAsync(Guid Id);
        Task<RestaurantSystem.Company.Api.Entities.Location> AddLocationAsync(RestaurantSystem.Company.Api.Entities.Location LocationDetails);
        Task<int> UpdateLocationAsync(RestaurantSystem.Company.Api.Entities.Location LocationDetails);
        Task<int> DeleteLocationAsync(Guid Id);
    }
}
