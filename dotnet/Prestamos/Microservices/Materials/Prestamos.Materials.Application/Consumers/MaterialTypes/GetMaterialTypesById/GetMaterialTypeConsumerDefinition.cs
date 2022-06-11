using MassTransit;

namespace Prestamos.Materials.Application.Consumers
{
    public class GetMaterialTypeConsumerDefinition : ConsumerDefinition<GetMaterialTypeByIdConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<GetMaterialTypeByIdConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}