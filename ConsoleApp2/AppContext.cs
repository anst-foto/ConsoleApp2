using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2;

public class AppContext : DbContext
{
    public DbSet<Test> Tests { get; set; }

    public AppContext(DbContextOptions options) 
        : base(options) { }
}