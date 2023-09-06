using Microsoft.AspNetCore.Mvc;

namespace ClassRPG.Controllers
{
    public class LoganController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
