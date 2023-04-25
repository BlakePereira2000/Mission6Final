using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6Final.Models;

namespace MovieMission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext context)
        {
            //this allows us to access the repository
            _logger = logger;
            _blahContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieList(AddMovie m)
        {
            //this adds the new movie to the database
            _blahContext.Add(m);
            _blahContext.SaveChanges();
            return View("Confirmation", m);
        }

        public IActionResult Podcast()
        {
            return View();
        }

        
    }
}

