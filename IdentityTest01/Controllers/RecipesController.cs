using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityTest01.Data;
using Microsoft.AspNetCore.Mvc;

namespace IdentityTest01.Controllers
{
    public class RecipesController : Controller
    {
        private readonly AppDbContext _context;

        public RecipesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("/Recipes/Index");
        }

        public IActionResult Create()
        {
            return View("/Recipes/Create");
        }

        public IActionResult Delete()
        {
            return View("/Recipes/Delete");
        }

        public IActionResult Details()
        {
            return View("/Recipes/Details");
        }

        public IActionResult Edit()
        {
            return View("/Recipes/Edit");
        }
    }
}