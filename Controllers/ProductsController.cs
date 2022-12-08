using EFCoreCodeFirstCrudApp.Models;
using EFCoreCodeFirstCrudApp.Repositories;
using EFCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreCrud.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepo productRepo;
        public ProductsController(IProductRepo repo)
        {
            productRepo = repo;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            productRepo.AddProduct(product);
            return Content("Prodcut has been inserted successfully");
        }
        public IActionResult Index()
        {
            var product = productRepo.GetAllProducts();
            return View(product);
        }
        public IActionResult GetDetail(int id)
        {
            var product = productRepo.GetProductDetail(id);
            return View(product);

        }

        public IActionResult Update(int id)
        {
            Product product = productRepo.GetProductDetail(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            Product p = productRepo.EditProduct(product);
            if (p != null)
                return RedirectToAction("Index");
            else
                return View();
        }
        public IActionResult Delete(int id)
        {
            Product product = productRepo.GetProductDetail(id);
            return View(product);
        }

        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            productRepo.DeleteProduct(product.Id);
            return RedirectToAction("Index");
        }
    }

}