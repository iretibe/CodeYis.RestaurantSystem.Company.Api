using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class CreateCurrencyCommand : IRequest<RestaurantSystem.Company.Api.Entities.Currency>
    {
        public Guid CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }

        public CreateCurrencyCommand(string currencyName, string currencyCode, string currencySymbol)
        {
            CurrencyID = Guid.NewGuid();
            CurrencyName = currencyName;
            CurrencyCode = currencyCode;
            CurrencySymbol = currencySymbol;
        }
    }
}
