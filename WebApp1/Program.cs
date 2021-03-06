﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).ConfigureAppConfiguration(
                (hostingContext, config) =>
                {
                    config.AddInMemoryCollection(
                        arrayDict
                        );
                })
                .UseStartup<Startup>();


        public static Dictionary<string, string> arrayDict = new Dictionary<string, string>
        {
            {"myoptions:id", "123"},
            {"myoptions:name", "456"}
        };


    }
}
