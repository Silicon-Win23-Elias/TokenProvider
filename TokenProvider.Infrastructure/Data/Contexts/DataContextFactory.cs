using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace TokenProvider.Infrastructure.Data.Contexts;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<DataContext>();
        optionBuilder.UseSqlServer("Server=tcp:sqlserver-silicon-hl.database.windows.net,1433;Initial Catalog=token_database;Persist Security Info=False;User ID=SqlAdmin;Password=HampusElias321!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        return new DataContext(optionBuilder.Options);
    }
}
