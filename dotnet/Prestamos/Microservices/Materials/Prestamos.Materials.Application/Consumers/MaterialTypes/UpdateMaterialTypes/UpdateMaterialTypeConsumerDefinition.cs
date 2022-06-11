using MassTransit;

namespace Prestamos.Materials.Application.Consumers
{
    public class UpdateMaterialTypeConsumerDefinition : ConsumerDefinition<UpdateMaterialTypeConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<UpdateMaterialTypeConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}