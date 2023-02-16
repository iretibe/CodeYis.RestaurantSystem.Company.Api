using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Company.Api.Data;
using RestaurantSystem.Company.Api.Entities;

namespace RestaurantSystem.Company.Api.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly CompanyDbContext _companyDbContext;

        public CityRepository(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public async Task<City> AddCityAsync(City CityDetails)
        {
            var result = _companyDbContext.Cities.Add(CityDetails);

            await _companyDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<int> DeleteCityAsync(Guid Id)
        {
            var filteredData = _companyDbContext.Cities.Where(x => x.CityID == Id).FirstOrDefault();

            _companyDbContext.Cities.Remove(filteredData);

            return await _companyDbContext.SaveChangesAsync();
        }

        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await _companyDbContext.Cities.ToListAsync();
        }

        public async Task<City> GetCityByIdAsync(Guid Id)
        {
            return await _companyDbContext.Cities.Where(x => x.CityID == Id).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateCityAsync(City CityDetails)
        {
            _companyDbContext.Cities.Update(CityDetails);

            return await _companyDbContext.SaveChangesAsync();
        }
    }
}
