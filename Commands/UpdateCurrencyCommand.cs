using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class UpdateCurrencyCommand : IRequest<int>
    {
        public Guid CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }

        public UpdateCurrencyCommand(Guid currencyID, string currencyName, string currencyCode, string currencySymbol)
        {
            CurrencyID = currencyID;
            CurrencyName = currencyName;
            CurrencyCode = currencyCode;
            CurrencySymbol = currencySymbol;
        }
    }
}
