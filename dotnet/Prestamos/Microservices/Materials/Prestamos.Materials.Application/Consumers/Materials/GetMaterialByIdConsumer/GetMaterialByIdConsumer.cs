using System.Threading.Tasks;
using MassTransit;
using Prestamos.Materials.Contracts.Messages.Materials;

namespace Prestamos.Materials.Application.Consumers.GetMaterialByIdConsumer
{
    public class GetMaterialByIdConsumer : IConsumer<GetMaterialById>
    {
        public Task Consume(ConsumeContext<GetMaterialById> context)
        {
            throw new System.NotImplementedException();
        }
    }
}