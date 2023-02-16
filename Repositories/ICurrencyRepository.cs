namespace RestaurantSystem.Company.Api.Repositories
{
    public interface ICurrencyRepository
    {
        Task<List<RestaurantSystem.Company.Api.Entities.Currency>> GetAllCurrenciesAsync();
        Task<RestaurantSystem.Company.Api.Entities.Currency> GetCurrencyByIdAsync(Guid Id);
        Task<RestaurantSystem.Company.Api.Entities.Currency> AddCurrencyAsync(RestaurantSystem.Company.Api.Entities.Currency CurrencyDetails);
        Task<int> UpdateCurrencyAsync(RestaurantSystem.Company.Api.Entities.Currency CurrencyDetails);
        Task<int> DeleteCurrencyAsync(Guid Id);
    }
}
