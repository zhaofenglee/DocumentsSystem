using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace JS.DocumentsSystem.Data;

public class DocumentsSystemEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public DocumentsSystemEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the DocumentsSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DocumentsSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
