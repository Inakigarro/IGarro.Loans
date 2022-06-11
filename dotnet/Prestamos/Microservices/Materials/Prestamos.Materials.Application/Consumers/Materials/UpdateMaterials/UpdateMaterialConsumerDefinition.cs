using MassTransit;

namespace Prestamos.Materials.Application.Consumers
{
    public class UpdateMaterialConsumerDefinition : ConsumerDefinition<UpdateMaterialConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<UpdateMaterialConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}