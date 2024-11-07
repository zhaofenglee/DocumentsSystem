using JS.DocumentsSystem.Localization;
using Volo.Abp.Application.Services;

namespace JS.DocumentsSystem.Services;

/* Inherit your application services from this class. */
public abstract class DocumentsSystemAppService : ApplicationService
{
    protected DocumentsSystemAppService()
    {
        LocalizationResource = typeof(DocumentsSystemResource);
    }
}