using MassTransit;

namespace Prestamos.Users.Application.Consumers
{
    public class CreateUserConsumerDefinition : 
        ConsumerDefinition<CreateUserConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<CreateUserConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}