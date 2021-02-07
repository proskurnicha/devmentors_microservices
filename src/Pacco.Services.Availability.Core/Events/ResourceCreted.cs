using Pacco.Services.Availability.Core.Entities;

namespace Pacco.Services.Availability.Core.Events
{
    public class ResourceCreted : IDomainEvent
    {
        public Resource Resource { get; }
        public ResourceCreted(Resource resource) => Resource = resource;
    }
}
