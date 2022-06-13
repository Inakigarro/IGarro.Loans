using MassTransit;

namespace Prestamos.Materials.Application.Consumers.MaterialTypes.GetAllMaterialTypes
{
    public class GetAllMaterialTypesConsumerDefinition : ConsumerDefinition<GetAllMaterialTypesConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<GetAllMaterialTypesConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}
