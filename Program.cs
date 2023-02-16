using MediatR;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Company.Api.Data;
using RestaurantSystem.Company.Api.Repositories;
using RestaurantSystem.Country.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration["connectionStrings:DefaultConnection"];
builder.Services.AddDbContext<CompanyDbContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddDbContext<CompanyDbContext>(
    dbContextOptions => dbContextOptions.UseSqlServer(
        builder.Configuration["connectionStrings:DefaultConnection"]));

builder.Services.AddMediatR(typeof(Program));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services
    .AddScoped<ICompanyRepository, CompanyRepository>()
    .AddScoped<ICountryRepository, CountryRepository>()
    .AddScoped<ICityRepository, CityRepository>()
    .AddScoped<ILocationRepository, LocationRepository>()
    .AddScoped<ICurrencyRepository, CurrencyRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
