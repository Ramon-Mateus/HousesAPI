using Microsoft.EntityFrameworkCore;

namespace HousesAPI.Contexts
{
    public class HouseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=houses.sqlite3");
        }
    }
}
