using Microsoft.AspNetCore.Mvc;

namespace BSUIR_VIS.UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
