using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Plugin;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.NovaPoshta
{
    public class ShippingWidgets : BasePlugin
    {

        //private readonly ILocalizationService _localizationService;
        //private readonly ISettingService _settingService;
        //private readonly IWebHelper _webHelper;

        //public ShippingWidgets(ILocalizationService localizationService,
        // ISettingService settingService,
        // IWebHelper webHelper)
        //{
        //    _localizationService = localizationService;
        //    _settingService = settingService;
        //    _webHelper = webHelper;
        //}
        //public bool HideInWidgetList => true;
        //public Task<IList<string>> GetWidgetZonesAsync()
        //{
        //    return Task.FromResult<IList<string>>(new List<string> { PublicWidgetZones.CheckoutShippingMethodTop });
        //}

        //public string GetWidgetViewComponentName(string widgetZone)
        //{
        //    return "WidgetNovaPoshta";
        //}


        //public override string GetConfigurationPageUrl()
        //{
        //    return _webHelper.GetStoreLocation() + "Admin/WidgetsNovaPoshta/Configure";
        //}

        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }


    }
}


