using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Prestamos.Users.Application.AutoMapperProfiles;
using Prestamos.Users.Application.Consumers;
using Prestamos.Users.Persistence;
using Prestamos.Users.Persistence.Repositories.Users;

namespace Prestamos.Users.Application
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
                        opts.AddProfile(new UserProfile());
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
                        
                        // Users consumers.
                        mt.AddConsumer<CreateUserConsumer, CreateUserConsumerDefinition>();
                        mt.AddConsumer<UpdateUserConsumer, UpdateUserConsumerDefinition>();
                        mt.AddConsumer<GetUserByIdConsumer, GetUserByIdConsumerDefinition>();
                        mt.AddConsumer<GetAllUsersConsumer, GetAllUsersConsumerDefinition>();
                    });

                    services.AddDbContext<UsersDbContext>(options =>
                    {
                        options.UseSqlServer(
                            "Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True",
                            assembly => assembly.MigrationsAssembly(typeof(UsersDbContext).Assembly.FullName));
                    });

                    services.AddScoped<IUserRepository, UsersRepository>();
                });
    }
}
