using MediatR;

namespace RestaurantSystem.Company.Api.Commands
{
    public class CreateLocationCommand : IRequest<RestaurantSystem.Company.Api.Entities.Location>
    {
        public Guid LocationID { get; set; }
        public string LocationName { get; set; }
        public bool IsDefault { get; set; }

        public CreateLocationCommand(string locationName, bool isDefault)
        {
            LocationID = Guid.NewGuid();
            LocationName = locationName;
            IsDefault = isDefault;
        }
    }
}
