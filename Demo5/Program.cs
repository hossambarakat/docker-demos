﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Demo5
{
    class Program
    {
        public static void Main(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.Configure(app =>
            {
                app.UseRouting();
                app.UseEndpoints(route =>
                {
                    route.MapGet("/", context => context.Response.WriteAsync("Hello world"));
                });
            });
        })
        .Build().Run();
    }
}
