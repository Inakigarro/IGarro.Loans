using MassTransit;

namespace Prestamos.Users.Application.Consumers
{
    public class GetAllUsersConsumerDefinition : ConsumerDefinition<GetAllUsersConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<GetAllUsersConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}