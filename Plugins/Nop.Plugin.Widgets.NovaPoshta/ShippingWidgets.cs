using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Plugin;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.NovaPoshta
{
    public class ShippingWidgets : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => true;

        string IWidgetPlugin.GetWidgetViewComponentName(string widgetZone)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string> { PublicWidgetZones.CheckoutShippingMethodTop });
        }

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "WidgetNovaPoshta";
        }
    }
}


