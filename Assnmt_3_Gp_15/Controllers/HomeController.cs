using Microsoft.AspNetCore.Mvc;

namespace Assnmt_3_Gp_15.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View("main");
        }

        public IActionResult Orlando()
        {
            return View("Greater_Orlando");
        }

        public IActionResult Tampa()
        {
            return View("Greater_Tampa");
        }

        public IActionResult Miami()
        {
            return View("Greater_Miami");
        }

        public IActionResult AboutProject()
        {
            return View("About_Project");
        }
        
        
    }
}
