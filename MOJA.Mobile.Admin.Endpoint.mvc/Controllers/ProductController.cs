using Microsoft.AspNetCore.Mvc;

namespace MOJA.Mobile.Admin.Endpoint.mvc.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
