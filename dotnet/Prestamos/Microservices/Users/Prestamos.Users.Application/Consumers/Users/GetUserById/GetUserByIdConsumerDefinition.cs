using MassTransit;

namespace Prestamos.Users.Application.Consumers
{
    public class GetUserByIdConsumerDefinition : ConsumerDefinition<GetUserByIdConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<GetUserByIdConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}