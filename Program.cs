using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    public class Program
    {
        // entry point
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        // sets up WebHost with default configuration
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            // create Startup.cs
                .UseStartup<Startup>();
    }
}
