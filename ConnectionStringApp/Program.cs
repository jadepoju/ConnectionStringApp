using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectionStringApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ConnectionStringApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // CreateHostBuilder(args).Build().Run();

            var host = CreateHostBuilder(args).Build();

            //implementing db seeder best practice
            using(var scope = host.Services.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetService<ProductContext>();

                    //MIGRATE DATA INTO DB if not exists
                    context.Database.Migrate();
                    //context.Database.EnsureCreated();

                }catch(Exception except)
                {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(except, $"Woa, something nasty just happened seeding database migration! hmmm");
                }
            }

            //run the the app
            host.Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
