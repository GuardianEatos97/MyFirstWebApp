using Microsoft.EntityFrameworkCore;
using MyFirstWebApp.Models.Entities;
namespace MyFirstWebApp.Database
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options): base(options)
        {  
        }

        public DbSet<Athlete> Athletes { get; set; }
    }
}
