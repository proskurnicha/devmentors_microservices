using Convey;
using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using Convey.CQRS.Events;

namespace Pacco.Services.Availability.Application
{
    public static class Extensions
    {
        public static IConveyBuilder AddApplication(this IConveyBuilder conveyBuilder)
            => conveyBuilder.AddCommandHandlers()
            .AddQueryHandlers()
            .AddInMemoryCommandDispatcher()
            .AddInMemoryQueryDispatcher();
    }
}
