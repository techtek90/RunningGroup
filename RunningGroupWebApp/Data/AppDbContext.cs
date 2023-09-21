using Microsoft.EntityFrameworkCore;
using RunningGroupWebApp.Models;

namespace RunningGroupWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresss { get; set; }
    }
}
