using System.Threading.Tasks;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prestamos.Materials.Application.AutoMapperProfiles;
using Prestamos.Materials.Application.Consumers;
using Prestamos.Materials.Application.Consumers.GetMaterialByIdConsumer;
using Prestamos.Materials.Application.Consumers.MaterialTypes.GetAllMaterialTypes;
using Prestamos.Materials.Persistence;
using Prestamos.Materials.Persistence.Repositories;
using Prestamos.Materials.Persistence.Repositories.Materials;

namespace Prestamos.Materials.Application
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddAutoMapper(opts =>
                    {
                        opts.AddProfile(new MaterialTypeProfile());
                        opts.AddProfile(new MaterialProfile());
                    });
                    
                    services.AddMassTransit(mt =>
                    {
                        mt.UsingRabbitMq((context, cfg) =>
                        {
                            cfg.Host("localhost", "/", h =>
                            {
                                h.Username("guest");
                                h.Password("guest");
                            });
                            
                            cfg.ConfigureEndpoints(context);
                        });
                        
                        // Material Consumers.
                        mt.AddConsumer<CreateMaterialConsumer, CreateMaterialConsumerDefinition>();
                        mt.AddConsumer<UpdateMaterialConsumer, UpdateMaterialConsumerDefinition>();
                        mt.AddConsumer<GetMaterialByIdConsumer, GetMaterialByIdConsumerDefinition>();
                        mt.AddConsumer<GetAllMaterialsConsumer, GetAllMaterialsConsumerDefinition>();
                        
                        // MaterialType Consumers.
                        mt.AddConsumer<CreateMaterialTypeConsumer, CreateMaterialTypeConsumerDefinition>();
                        mt.AddConsumer<UpdateMaterialTypeConsumer, UpdateMaterialTypeConsumerDefinition>();
                        mt.AddConsumer<GetMaterialTypeByIdConsumer, GetMaterialTypeConsumerDefinition>();
                        mt.AddConsumer<GetAllMaterialTypesConsumer, GetAllMaterialTypesConsumerDefinition>();
                    });

                    services.AddDbContext<MaterialsDbContext>(options =>
                    {
                        options.UseSqlServer(
                            "Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True",
                            assembly => assembly.MigrationsAssembly(typeof(MaterialsDbContext).Assembly.FullName));
                    });

                    services.AddScoped<IMaterialTypeRepository, MaterialTypeRepository>();
                    services.AddScoped<IMaterialRepository, MaterialRepository>();
                });
    }
}