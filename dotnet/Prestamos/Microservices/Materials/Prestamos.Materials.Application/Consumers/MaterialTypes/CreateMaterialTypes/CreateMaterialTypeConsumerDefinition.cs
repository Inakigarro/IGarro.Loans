using MassTransit;

namespace Prestamos.Materials.Application.Consumers
{
    public class CreateMaterialTypeConsumerDefinition : ConsumerDefinition<CreateMaterialTypeConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<CreateMaterialTypeConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}