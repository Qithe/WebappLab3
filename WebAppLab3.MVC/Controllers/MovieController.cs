using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppLab3.MVC.Models;

namespace WebAppLab3.MVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly Context Context;

        public MovieController(Context context)
        {
            Context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await Context.movies.ToListAsync());
        }
    }
}