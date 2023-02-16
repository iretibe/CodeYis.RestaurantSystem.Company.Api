using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Company.Api.Data;
using RestaurantSystem.Company.Api.Entities;

namespace RestaurantSystem.Company.Api.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly CompanyDbContext _companyDbContext;

        public CurrencyRepository(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public async Task<Currency> AddCurrencyAsync(Currency CurrencyDetails)
        {
            var result = _companyDbContext.Currencies.Add(CurrencyDetails);

            await _companyDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<int> DeleteCurrencyAsync(Guid Id)
        {
            var filteredData = _companyDbContext.Currencies.Where(x => x.CurrencyID == Id).FirstOrDefault();

            _companyDbContext.Currencies.Remove(filteredData);

            return await _companyDbContext.SaveChangesAsync();
        }

        public async Task<List<Currency>> GetAllCurrenciesAsync()
        {
            return await _companyDbContext.Currencies.ToListAsync();
        }

        public async Task<Currency> GetCurrencyByIdAsync(Guid Id)
        {
            return await _companyDbContext.Currencies.Where(x => x.CurrencyID == Id).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateCurrencyAsync(Currency CurrencyDetails)
        {
            _companyDbContext.Currencies.Update(CurrencyDetails);

            return await _companyDbContext.SaveChangesAsync();
        }
    }
}
