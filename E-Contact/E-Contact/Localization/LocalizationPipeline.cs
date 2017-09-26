using Microsoft.AspNetCore.Builder;

namespace E_Contact
{
    public class LocalizationPipeline
    {
        public void Configure(IApplicationBuilder app, RequestLocalizationOptions options)
        {
            app.UseRequestLocalization(options);
            app.UseMiddleware<RedirectUnsupportedCulturesMiddleware>();
        }
    }
}
