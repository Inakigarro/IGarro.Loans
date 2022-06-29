using MassTransit;

namespace Prestamos.Users.Application.Consumers
{
    public class UpdateUserConsumerDefinition : ConsumerDefinition<UpdateUserConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<UpdateUserConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}