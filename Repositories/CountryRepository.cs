using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Company.Api.Data;
using RestaurantSystem.Country.Api.Repositories;

namespace RestaurantSystem.Company.Api.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly CompanyDbContext _companyDbContext;

        public CountryRepository(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public async Task<Entities.Country> AddCountryAsync(Entities.Country CountryDetails)
        {
            var result = _companyDbContext.Countries.Add(CountryDetails);

            await _companyDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<int> DeleteCountryAsync(Guid Id)
        {
            var filteredData = _companyDbContext.Countries.Where(x => x.CountryID == Id).FirstOrDefault();

            _companyDbContext.Countries.Remove(filteredData);

            return await _companyDbContext.SaveChangesAsync();
        }

        public async Task<List<Entities.Country>> GetAllCountriesAsync()
        {
            return await _companyDbContext.Countries.ToListAsync();
        }

        public async Task<Entities.Country> GetCountryByIdAsync(Guid Id)
        {
            return await _companyDbContext.Countries.Where(x => x.CountryID == Id).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateCountryAsync(Entities.Country CountryDetails)
        {
            _companyDbContext.Countries.Update(CountryDetails);

            return await _companyDbContext.SaveChangesAsync();
        }
    }
}
