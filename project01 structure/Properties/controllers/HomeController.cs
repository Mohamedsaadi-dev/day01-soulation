using Microsoft.AspNetCore.Mvc;
using project01_structure.Properties.models;

namespace project01_structure.Properties.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /// return View("hamada",new Movie());
            /// return View("hamada");
            /// return View(new Movie());
            return View();
        }
        public ActionResult Privecy()
            
        {  return View(); }
        public ActionResult AboutUs()

        { return View(); }
    }
}
