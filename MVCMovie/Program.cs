using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie
{
    public class Program
    {
       static IHostBuilder builder;
        public static void Main(string[] args)
        {
            builder = CreateHostBuilder(args);
            builder.Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    //    builder.Services.AddDbContext<MvcMovieContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));
    }
}
