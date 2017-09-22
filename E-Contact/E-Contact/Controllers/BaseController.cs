using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace E_Contact.Controllers
{
    public class BaseController : Controller
    {
        private string _currentLanguage;

        public string CurrentLanguage
        {
            get
            {
                if (!string.IsNullOrEmpty(_currentLanguage))
                {
                    return _currentLanguage;
                }



                if (string.IsNullOrEmpty(_currentLanguage))
                {
                    var feature = HttpContext.Features.Get<IRequestCultureFeature>();
                    _currentLanguage = feature.RequestCulture.Culture.TwoLetterISOLanguageName.ToLower();
                }

                return _currentLanguage;
            }
        }
    }
}
