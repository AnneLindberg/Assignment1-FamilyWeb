using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;
using WebApplication.DataAccess;

namespace WebApplication
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using (AdultDBContext adultDbContext = new AdultDBContext())
            {
                if (!adultDbContext.Adults.Any())
                {
                    Seed(adultDbContext);
                }
                
            }
            CreateHostBuilder(args).Build().Run();
        }

        private static void Seed(AdultDBContext adultDbContext)
        {
            IList<Adult> adults;
            Adult[] ts =
            {
                new Adult()
                {
                    age = 26,
                    eyeColor = "Blue",
                    firstName = "Anne",
                    hairColor = "leverpostej",
                    height = 160,
                    id = 1,
                    JobTitle = "Student",
                    lastName = "Lindberg",
                    sex = "Female",
                    weight = 62
                }
            };
            ts.ToList();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}