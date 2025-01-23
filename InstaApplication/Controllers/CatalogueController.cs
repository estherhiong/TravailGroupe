using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Vuecatalogue()
        {
            TempData["age"] = "Test data";
            return View();
        }

        public IActionResult Modifier()
        { 
            return View();
        }

        public IActionResult Consulter()
        {
            return View();
        }
    }
}
