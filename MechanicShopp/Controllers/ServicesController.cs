
using MechanicShopp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MechanicShopp.Controllers
{
    public class ServicesController : Controller
    {
        private static List<Service> _services = new List<Service>();

        public IActionResult Index()
        {
            return View(_services);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {
            if (ModelState.IsValid)
            {
                service.Id = _services.Count + 1;
                _services.Add(service);
                return RedirectToAction("Index");
            }

            return View(service);
        }
    }
}
