using Microsoft.EntityFrameworkCore;
using Models;

namespace WebApplication.DataAccess
{
    public class AdultDBContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = Adults.db");
        }
    }
}