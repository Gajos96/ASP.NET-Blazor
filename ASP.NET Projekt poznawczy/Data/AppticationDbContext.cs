using ASP.NET_Projekt_poznawczy.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Projekt_poznawczy
{
    public class AppticationDbContext : DbContext
    {
        public AppticationDbContext(DbContextOptions<AppticationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> users { get; set; }


    }
}
