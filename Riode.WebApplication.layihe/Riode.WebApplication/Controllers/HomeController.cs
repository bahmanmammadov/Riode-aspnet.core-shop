using Microsoft.AspNetCore.Mvc;

namespace Riode.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public  IActionResult Index()
        {

            return View();
        }
        public IActionResult AboutUs()
        {

            return View();
        }
    }
}
