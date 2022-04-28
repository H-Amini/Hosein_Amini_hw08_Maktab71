using Hosein_Amini_hw08_Maktab71.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hosein_Amini_hw08_Maktab71.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(PersonRepository.GetAllPerson());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View("Contact");
        }
        public IActionResult Delete(Guid id)
        {
            PersonRepository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Layout()
        {
            return View();
        }
        public IActionResult Edit(Guid id)
        {
            return View(PersonRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(PersonModel person)
        {
            PersonRepository.Edit(person);
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}