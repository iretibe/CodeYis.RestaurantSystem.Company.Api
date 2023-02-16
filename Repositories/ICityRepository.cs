namespace RestaurantSystem.Company.Api.Repositories
{
    public interface ICityRepository
    {
        Task<List<RestaurantSystem.Company.Api.Entities.City>> GetAllCitiesAsync();
        Task<RestaurantSystem.Company.Api.Entities.City> GetCityByIdAsync(Guid Id);
        Task<RestaurantSystem.Company.Api.Entities.City> AddCityAsync(RestaurantSystem.Company.Api.Entities.City CityDetails);
        Task<int> UpdateCityAsync(RestaurantSystem.Company.Api.Entities.City CityDetails);
        Task<int> DeleteCityAsync(Guid Id);
    }
}
