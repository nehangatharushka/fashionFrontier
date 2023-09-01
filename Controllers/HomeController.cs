﻿using fashionFrontier.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace fashionFrontier.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly fashionfrontierContext _dbContext;

        public HomeController(ILogger<HomeController> logger, fashionfrontierContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Explore()
        {
            var products = _dbContext.Products.ToList();
            return View(products);
        }

        //[Route("Products/Index/{categoryName}")]
        public IActionResult Explore(string categoryName)
        {
            var products = _dbContext.Products.ToList();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}