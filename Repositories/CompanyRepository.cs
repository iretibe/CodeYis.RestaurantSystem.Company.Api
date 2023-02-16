using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Company.Api.Data;

namespace RestaurantSystem.Company.Api.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyDbContext _companyDbContext;

        public CompanyRepository(CompanyDbContext companyDbContext)
        {
            _companyDbContext = companyDbContext;
        }

        public async Task<Entities.Company> AddCompanyAsync(Entities.Company CompanyDetails)
        {
            var result = _companyDbContext.Companies.Add(CompanyDetails);

            await _companyDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<int> DeleteCompanyAsync(Guid Id)
        {
            var filteredData = _companyDbContext.Companies.Where(x => x.CompanyID == Id).FirstOrDefault();

            _companyDbContext.Companies.Remove(filteredData);

            return await _companyDbContext.SaveChangesAsync();
        }

        public async Task<List<Entities.Company>> GetAllCompaniesAsync()
        {
            return await _companyDbContext.Companies.ToListAsync();
        }

        public async Task<Entities.Company> GetCompanyByIdAsync(Guid Id)
        {
            return await _companyDbContext.Companies.Where(x => x.CompanyID == Id).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateCompanyAsync(Entities.Company CompanyDetails)
        {
            _companyDbContext.Companies.Update(CompanyDetails);

            return await _companyDbContext.SaveChangesAsync();
        }
    }
}
