using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class PassdataController : Controller
    {
        public IActionResult Data()
        {
            TempData["user"] = "tempdata";
            var data = TempData["user"];
            ViewData["user"] = data;
            TempData.Keep();
            return View();
        }

        public IActionResult Data2 ()
        {
            
            return View();
        }

        
    }
}
