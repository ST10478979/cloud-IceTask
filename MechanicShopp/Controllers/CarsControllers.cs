
using MechanicShopp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MechanicShopp.Controllers
{
    public class CarsController : Controller
    {
        // This is our magic toy box that remembers all the cars
        private static List<Car> _cars = new List<Car>();

        // INDEX = "Show me all the cars!"
        public IActionResult Index()
        {
            return View(_cars);   // Shows the list to the person on the website
        }

        // CREATE GET = "Show me the empty form so I can add a new car"
        public IActionResult Create()
        {
            return View();   // Just shows a blank form
        }

        // CREATE POST = "Okay, they filled the form! Save the new car"
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)   // Did they fill everything correctly?
            {
                car.Id = _cars.Count + 1;   // Give it a new number like 1, 2, 3...
                _cars.Add(car);             // Put the new car in the magic box
                return RedirectToAction("Index");  // Take them back to see the full list
            }

            return View(car);   // If something was wrong, show the form again with their mistakes
        }
    }
}
