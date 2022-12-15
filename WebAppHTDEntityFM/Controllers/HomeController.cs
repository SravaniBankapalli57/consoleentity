﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppHTDEntityFM.Models;

namespace WebAppHTDEntityFM.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Privacy1()
        {
            return View();
        }
        public IActionResult Privacy2ttre()
        {
            return View();
        }
        public IActionResult Privacy3()
        {
            return View();
        }
        public IActionResult Privacy4()
        {
            return View();
        }
    }
}
