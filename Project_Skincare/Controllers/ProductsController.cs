using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Skincare.Data;

namespace Project_Skincare.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext db;
        public ProductsController(ApplicationDbContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index()// afisarea tuturor produselor, se util GET, intotdeauna se executa implicit http get
        {
            var l_products = db.Products.Include("Category");
            ViewBag.AllProducts = l_products;
            return View();
        }
    }
}
