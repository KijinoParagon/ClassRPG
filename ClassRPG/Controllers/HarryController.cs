using Microsoft.AspNetCore.Mvc;

namespace ClassRPG.Controllers
{
    public class HarryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
