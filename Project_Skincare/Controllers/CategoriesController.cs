﻿using Microsoft.AspNetCore.Mvc;
using Project_Skincare.Data;

namespace Project_Skincare.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext db;
        public CategoriesController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
