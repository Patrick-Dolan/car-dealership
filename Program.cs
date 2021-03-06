using System;
using System.Collections.Generic;
using System.IO;
using CarDealership.Models;
using Microsoft.AspNetCore.Hosting;

namespace CarDealership
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}