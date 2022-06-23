using MassTransit;

namespace Prestamos.Materials.Application.Consumers
{
    public class GetAllMaterialsConsumerDefinition : ConsumerDefinition<GetAllMaterialsConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<GetAllMaterialsConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}