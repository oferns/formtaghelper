
namespace FormTest.Controllers {
    using FormTest.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;

    //[Area("Products")]
    public class ApplyController : Controller {
        private readonly IHtmlGenerator generator;

        public ApplyController(IHtmlGenerator generator) {
            this.generator = generator ?? throw new System.ArgumentNullException(nameof(generator));
        }

        [HttpGet]
        public IActionResult NoArg() {
            //    var helper = new FormTagHelper(generator);
            return View("ProductsNoArg");

        }


        [HttpGet]
        public IActionResult Index(int eid) {
        //    var helper = new FormTagHelper(generator);
            return View("Products", new ProductViewModel { ProductId = eid });

        }

        [HttpPost]
        public IActionResult Index(int eid, ProductViewModel model) {
            return View("Products");
        }





    }
}
