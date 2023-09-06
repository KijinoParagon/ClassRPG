using ClassRPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassRPG.Controllers
{
    public class JordanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display(JordanModel model)
        {
            return View(model);
        }
    }
}
