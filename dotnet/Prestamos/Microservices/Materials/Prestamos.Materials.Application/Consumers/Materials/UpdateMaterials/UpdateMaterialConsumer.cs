using System.Threading.Tasks;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.Materials;

namespace Prestamos.Materials.Application.Consumers
{
    public class UpdateMaterialConsumer : IConsumer<UpdateMaterial>
    {
        public Task Consume(ConsumeContext<UpdateMaterial> context)
        {
            throw new System.NotImplementedException();
        }
    }
}