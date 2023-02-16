namespace RestaurantSystem.Company.Api.Repositories
{
    public interface ICompanyRepository
    {
        public Task<List<RestaurantSystem.Company.Api.Entities.Company>> GetAllCompaniesAsync();
        public Task<RestaurantSystem.Company.Api.Entities.Company> GetCompanyByIdAsync(Guid Id);
        public Task<RestaurantSystem.Company.Api.Entities.Company> AddCompanyAsync(RestaurantSystem.Company.Api.Entities.Company CompanyDetails);
        public Task<int> UpdateCompanyAsync(RestaurantSystem.Company.Api.Entities.Company CompanyDetails);
        public Task<int> DeleteCompanyAsync(Guid Id);
    }
}
