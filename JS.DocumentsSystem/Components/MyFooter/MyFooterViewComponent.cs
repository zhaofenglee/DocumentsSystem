using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace JS.DocumentsSystem.Components.MyFooter;


public class MyFooterViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Components/MyFooter/Default.cshtml");
    }
}