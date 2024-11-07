using Microsoft.AspNetCore.Mvc;
using Project_Skincare.Data;

namespace Project_Skincare.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext db;
        public ReviewsController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
