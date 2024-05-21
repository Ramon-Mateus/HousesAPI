using HousesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HousesAPI.Contexts
{
    public class HouseContext : DbContext
    {
        public DbSet<House> Houses => Set<House>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=houses.sqlite3");
        }
    }
}
