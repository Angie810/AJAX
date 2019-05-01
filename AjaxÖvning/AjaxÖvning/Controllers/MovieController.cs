using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxÖvning.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxÖvning.Controllers
{
    public class MovieController : Controller
    {

        MovieService service;
        public MovieController(MovieService service)
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

    }
}