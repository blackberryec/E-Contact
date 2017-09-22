using Microsoft.AspNetCore.Mvc;

namespace E_Contact.Controllers
{
    [MiddlewareFilter(typeof(LocalizationPipeline))]
    public class HomeController : BaseController
    {

        public ActionResult RedirectToDefaultLanguage()
        {
            var lang = CurrentLanguage;
            if (lang == "et")
            {
                lang = "ee";
            }

            return RedirectToAction("Index", new { lang = lang });
        }

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
