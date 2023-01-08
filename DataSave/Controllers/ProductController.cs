using Microsoft.AspNetCore.Mvc;

namespace DataSave.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
