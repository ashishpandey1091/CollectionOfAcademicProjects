using Microsoft.AspNet.Mvc;
using ConverterPandey.Models;

namespace ConverterPandey.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Converter App by Pandey";
            ViewData["Result"] = "";

            Converter converter = new Converter();
            return View(converter);
        }

        public IActionResult Convert(Converter converter)
        {
            if (ModelState.IsValid)
            {
                ViewData["Title"] = "Converted by Pandey";
                ViewData["Result"] = "Temperature in C = " +
                    (int)((converter.Temperature_F - 32) * 5.0 / 9.0);
            }
            return View("Index", converter);
        }

    }
}
