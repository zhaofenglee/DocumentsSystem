using Microsoft.Extensions.Localization;
using JS.DocumentsSystem.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace JS.DocumentsSystem;

[Dependency(ReplaceServices = true)]
public class DocumentsSystemBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<DocumentsSystemResource> _localizer;

    public DocumentsSystemBrandingProvider(IStringLocalizer<DocumentsSystemResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
