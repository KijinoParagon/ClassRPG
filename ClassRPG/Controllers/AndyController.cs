using ClassRPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassRPG.Controllers
{
    public class AndyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display(AndyModel model)
        {
            return View(model);
        }

        public IActionResult Psychadelic() 
        { 
            return View(); 
        }
    }
}
