using ClassRPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassRPG.Controllers
{
    public class GarrettController : Controller
    {
        public IActionResult Index() { return View(); }

        public IActionResult Display(GarrettModel model) { return View(model); }
    }
}
