using Microsoft.AspNetCore.Mvc;
using SmartHomeMVC.Models;
using System;

namespace SmartHomeMVC.Controllers
{
    public class DashboardController : Controller
    {
        // Keeps state in memory
        private static SmartHomeModel model = new SmartHomeModel
        {
            IsLightOn = false,
            IsFanOn = false,
            Temperature = 25,
            RoomStatus = "Empty"
        };

        public IActionResult Index()
        {
            return View(model);
        }

        [HttpPost]
        public IActionResult ToggleLight()
        {
            model.IsLightOn = !model.IsLightOn;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ToggleFan()
        {
            model.IsFanOn = !model.IsFanOn;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Refresh()
        {
            Random rnd = new Random();
            model.Temperature = rnd.Next(22, 31); // 22°C to 30°C
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SetRoomStatus(string status)
        {
            model.RoomStatus = status;
            return RedirectToAction("Index");
        }
    }
}
