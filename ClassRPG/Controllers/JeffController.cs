using ClassRPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassRPG.Controllers
{
    public class JeffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
