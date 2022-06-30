using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using TrimitOppg.Controllers;
using Dapper;
using System.Data.SqlClient;
//using WebApplication9.Model;

namespace TrimitOppg
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            //jeg skal skrive den i .NET 6
            //var builder = WebApplication.CreateBuilder(args);
            //var app = builder.Build();
            //app.UseHttpsRedirection();
            //app.MapGet("/joke", async () =>
            //{
            //    var client = new RestClient("https://api.chucknorris.io/jokes/random");
            //    var request = new RestRequest();
            //    var joke = await client.GetAsync<ApiJoke>(request);
            //    return new JokeViewModel
            //    {
            //        JokeText = joke.value
            //    };
            //});
            // app.Run();
            // app.UseStaticFiles();
            // kode fra terje

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
