using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SallyPieShop
{
    public class Program
    {
        public static void Main(string[] args) //A host is set up that will configure a server and a request processing pipeline
        {
            CreateHostBuilder(args).Build().Run(); //CreateHostBuilder method will set up the application with some defaults
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); //UseStartup method specifies the startup class, which will perform the configuration of the application
                });
    }
}
