using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;
using WebApplication.DataAccess;

namespace WebApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (AdultDBContext adultDbContext = new AdultDBContext())
            {
                if (!adultDbContext.Adults.Any())
                {
                  InsertAdult();
                }
                
            }
            CreateHostBuilder(args).Build().Run();
        }

    
        private static async Task InsertAdult()
        {
            Adult adult1 = new Adult
            {
                age = 26,
                eyeColor = "Blue",
                firstName = "Anne",
                hairColor = "Blonde",
                height = 164,
                JobTitle = "Student",
                lastName = "Lindberg"
            };
            
            using (AdultDBContext dbContext = new AdultDBContext())
            {
                await dbContext.Adults.AddAsync(adult1);
                await dbContext.SaveChangesAsync();
            }
        }

        private static async Task UpdateAdult()
        {
            using (AdultDBContext dbContext = new AdultDBContext())
            {
                IQueryable<Adult> result = dbContext.Adults.Where(a => a.Equals("adult1"));
                Adult adult = await dbContext.Adults.FirstAsync(a => a.Equals("adult1"));
                
            }
        }
        
        private static async Task RemoveAdult()
        {
            using (AdultDBContext dbContext = new AdultDBContext())
            {
                IQueryable<Adult> result = dbContext.Adults.Where(a => a.Equals("adult1"));
                Adult adult = await dbContext.Adults.FirstAsync(a => a.Equals("adult1"));

                dbContext.Remove(adult);
                dbContext.SaveChangesAsync();
            }
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}