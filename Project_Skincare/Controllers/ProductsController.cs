using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
