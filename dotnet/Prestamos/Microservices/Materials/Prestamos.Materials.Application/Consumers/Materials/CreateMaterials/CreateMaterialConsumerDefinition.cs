using MassTransit;

namespace Prestamos.Materials.Application.Consumers
{
    public class CreateMaterialConsumerDefinition :
        ConsumerDefinition<CreateMaterialConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<CreateMaterialConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}