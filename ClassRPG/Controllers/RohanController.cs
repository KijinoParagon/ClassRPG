using Microsoft.AspNetCore.Mvc;

namespace ClassRPG.Controllers
{
    public class RohanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
