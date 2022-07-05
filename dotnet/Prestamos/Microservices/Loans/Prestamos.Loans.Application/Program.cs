using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Prestamos.Loans.Application.AutoMapperProfiles;
using Prestamos.Loans.Persistence;

namespace Prestamos.Loans.Application
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
                        opts.AddProfile(new LoanProfile());
                        opts.AddProfile(new LoanLineProfile());
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
                    });
                    
                    services.AddDbContext<LoansDbContext>(options =>
                    {
                        options.UseSqlServer(
                            "Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True",
                            assembly => assembly.MigrationsAssembly(typeof(LoansDbContext).Assembly.FullName));
                    });
                });
    }
}
