using MapApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MapApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            
            return View();
        }

    }

}