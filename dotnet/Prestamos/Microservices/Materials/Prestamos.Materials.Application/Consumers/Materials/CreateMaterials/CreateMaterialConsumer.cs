using System.Threading.Tasks;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.Materials;

namespace Prestamos.Materials.Application.Consumers
{
    public class CreateMaterialConsumer : IConsumer<CreateMaterial>
    {
        public Task Consume(ConsumeContext<CreateMaterial> context)
        {
            throw new System.NotImplementedException();
        }
    }
}