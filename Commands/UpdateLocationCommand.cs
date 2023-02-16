using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class UpdateLocationCommand : IRequest<int>
    {
        public Guid LocationID { get; set; }
        public string LocationName { get; set; }
        public bool IsDefault { get; set; }

        public UpdateLocationCommand(Guid locationID, string locationName, bool isDefault)
        {
            LocationID = locationID;
            LocationName = locationName;
            IsDefault = isDefault;
        }
    }
}
