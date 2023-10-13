using LabNet.DataBase;
using LabNet.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;

namespace LabNet.Admin
{
    [Route("admin/product")]
    public class ProductController : Controller
    {
        [HttpGet("list", Name = "product-list")]
        public IActionResult List()
        {
            var products = DBContext._products.Select(p=> new ListViewModel(p.Id, p.Name, p.Content, p.Price)).ToList();
            return View(products);
        }
        [HttpGet("add", Name ="product-add")]
        public IActionResult Add()
        {
            return View();
        }
    }
}
