using Microsoft.AspNetCore.Mvc;

namespace ASP.NETMVCOne.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ContentResult AboutData()
        {
          return  Content("Web Application");
        }

        public ViewResult ViewAbout()
        {
            return View();
        }
    }
}
