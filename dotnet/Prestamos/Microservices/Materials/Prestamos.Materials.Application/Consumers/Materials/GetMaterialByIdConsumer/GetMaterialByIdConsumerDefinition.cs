using MassTransit;

namespace Prestamos.Materials.Application.Consumers.GetMaterialByIdConsumer
{
    public class GetMaterialByIdConsumerDefinition : ConsumerDefinition<GetMaterialByIdConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<GetMaterialByIdConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}