using Microsoft.AspNetCore.Mvc;

namespace Assnmt_3_Gp_15.Controllers
{
    public class HomeController : Controller
    {

        //public IActionResult Index()
        //{
        //    int hour = DateTime.Now.Hour;
        //    ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
        //    return View("myView");
        //}

        //public IActionResult Index()
        //{
        //    return View("Data");
        //}



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
        
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
