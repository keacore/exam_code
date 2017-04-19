﻿using System;
using Microsoft.AspNetCore.Hosting;
using  Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5003")
                .Build();

            host.Run();
        }
    }
}
