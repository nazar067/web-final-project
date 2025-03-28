using Hotels.Models;
using Hotels.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Controllers
{
    public class HomeController : Controller
    {
        HotelsContext context;

        public HomeController(HotelsContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> SendMessage()
        {
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync("kasich.nszar@gmail.com", "Thank you", "Thank you for ordering our hotel");
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var hotels = context.Hotels.ToList();
            return View(hotels);
        }

        [HttpGet]
        public IActionResult More(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.HostelsId = id;
            var info = context.Hotels.Where(x => x.Id == id);
            return View(info);
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            ViewBag.HotelsId = id;

            if (TempData["SuccessMessage"] != null)
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }

            return View();
        }

        [HttpPost]
        public IActionResult Buy(Order orders)
        {
            if (string.IsNullOrWhiteSpace(orders.Name))
            {
                ModelState.AddModelError("Name", "Enter your name");
            }
            if (string.IsNullOrWhiteSpace(orders.Lastname))
            {
                ModelState.AddModelError("Lastname", "Enter your last name");
            }
            if (string.IsNullOrWhiteSpace(orders.Email))
            {
                ModelState.AddModelError("Email", "Enter your email");
            }
            if (orders.Phone == 0)
            {
                ModelState.AddModelError("Phone", "Enter your phone");
            }

            if (ModelState.IsValid)
            {
                orders.Id = 0;

                context.Orders.Add(orders);
                context.SaveChanges();

                TempData["SuccessMessage"] = "Thank you for your order! Your request has been successfully submitted.";

                return RedirectToAction("Buy");
            }

            return View(orders);
        }
    }
}
