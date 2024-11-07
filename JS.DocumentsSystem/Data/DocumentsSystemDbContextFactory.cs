using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace JS.DocumentsSystem.Data;

public class DocumentsSystemDbContextFactory : IDesignTimeDbContextFactory<DocumentsSystemDbContext>
{
    public DocumentsSystemDbContext CreateDbContext(string[] args)
    {
        DocumentsSystemEfCoreEntityExtensionMappings.Configure();
        
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DocumentsSystemDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new DocumentsSystemDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
