using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ConsoleApp2;

public class AppContextFactory : IDesignTimeDbContextFactory<AppContext>
{
    public AppContext CreateDbContext(string[] args)
    {
        const string connectionString = "Server=127.0.0.1;Port=5432;Database=test;User Id=postgres;Password=1234;";
        var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
        optionsBuilder.UseNpgsql(connectionString);
        
        return new AppContext(optionsBuilder.Options);
    }
}