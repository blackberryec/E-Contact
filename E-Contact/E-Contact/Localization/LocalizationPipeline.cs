using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace E_Contact
{
    public class LocalizationPipeline
    {
        /*There’s one issue. Routes are defined when MVC is configured. When localization is configured there are no routes. If we configure localization later then MVC has no idea about it. To solve this puzzle we will use special pipeline class with MiddlewareFilterAttribute.*/

        public void Configure(IApplicationBuilder app)
        {

            var supportedCultures = new List<CultureInfo>
                                {
                                    new CultureInfo("et"),
                                    new CultureInfo("en"),
                                    new CultureInfo("ru"),
                                };

            var options = new RequestLocalizationOptions()
            {

                DefaultRequestCulture = new RequestCulture(culture: "et", uiCulture: "et"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };

            options.RequestCultureProviders = new[] { new RouteDataRequestCultureProvider() { Options = options } };

            app.UseRequestLocalization(options);
        }
    }
}
