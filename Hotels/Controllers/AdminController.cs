using Hotels.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController: Controller
    {
        HotelsContext context;
        public AdminController(HotelsContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Hotels.ToList());
        }
        public IActionResult Create(int? hotelId)
        {
            if (hotelId == null)
            {
                return View();
            }
            else
            {
                return View(context.Hotels.FirstOrDefault(x => x.Id == hotelId));
            }
        }
        [HttpPost]
        public IActionResult Create(Hotel hotels)
        {
            if (hotels.Id == 0)
            {
                context.Hotels.Add(hotels);
            }
            else
            {
                context.Update(hotels);
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int hotelId)
        {
            var hotelToDelete = context.Hotels.Find(hotelId);
            context.Hotels.Remove(hotelToDelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
