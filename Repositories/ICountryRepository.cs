namespace RestaurantSystem.Country.Api.Repositories
{
    public interface ICountryRepository
    {
        Task<List<RestaurantSystem.Company.Api.Entities.Country>> GetAllCountriesAsync();
        Task<RestaurantSystem.Company.Api.Entities.Country> GetCountryByIdAsync(Guid Id);
        Task<RestaurantSystem.Company.Api.Entities.Country> AddCountryAsync(RestaurantSystem.Company.Api.Entities.Country CountryDetails);
        Task<int> UpdateCountryAsync(RestaurantSystem.Company.Api.Entities.Country CountryDetails);
        Task<int> DeleteCountryAsync(Guid Id);
    }
}
