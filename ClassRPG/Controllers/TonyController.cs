using Microsoft.AspNetCore.Mvc;

namespace ClassRPG.Controllers
{
    public class TonyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
