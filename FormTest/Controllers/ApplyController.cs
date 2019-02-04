
namespace FormTest.Controllers {
    using FormTest.Models;
    using Microsoft.AspNetCore.Mvc;


    [Area("Products")]
    public class ApplyController : Controller {

        [HttpGet]
        public IActionResult Index(int eid) {
            return View("Products", new ProductViewModel { ProductId = eid });
        }

        [HttpPost]
        public IActionResult Index(int eid, ProductViewModel model) {
            return View("Products");
        }
    }
}
