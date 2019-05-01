using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxÖvning.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxÖvning.Controllers
{
    public class HomeController : Controller
    {
        MovieService service;
        public HomeController(MovieService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View(service.GetAllMovies());
        }
        [HttpGet]

        public IActionResult Moviebox(int id)
        {
            return PartialView("_MovieBox", service.GetMovieById(id));
        }

        [HttpGet]

        public IActionResult MovieboxJSON(int id)
        {
            return Json(service.GetMovieById(id));

        }
        public IActionResult About()
        {
            throw new Exception("Det blir fel.");

        }



    }
}