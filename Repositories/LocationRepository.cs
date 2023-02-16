using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Company.Api.Data;
using RestaurantSystem.Company.Api.Entities;

namespace RestaurantSystem.Company.Api.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly CompanyDbContext _companyDbContext;

        public LocationRepository(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public async Task<Location> AddLocationAsync(Location LocationDetails)
        {
            var result = _companyDbContext.Locations.Add(LocationDetails);

            await _companyDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<int> DeleteLocationAsync(Guid Id)
        {
            var filteredData = _companyDbContext.Locations.Where(x => x.LocationID == Id).FirstOrDefault();

            _companyDbContext.Locations.Remove(filteredData);

            return await _companyDbContext.SaveChangesAsync();
        }

        public async Task<List<Location>> GetAllLocationsAsync()
        {
            return await _companyDbContext.Locations.ToListAsync();
        }

        public async Task<Location> GetLocationByIdAsync(Guid Id)
        {
            return await _companyDbContext.Locations.Where(x => x.LocationID == Id).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateLocationAsync(Location LocationDetails)
        {
            _companyDbContext.Locations.Update(LocationDetails);

             return await _companyDbContext.SaveChangesAsync();
        }
    }
}
