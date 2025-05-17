using Microsoft.AspNetCore.Mvc;
using PracticeCRUD.Data;
using PracticeCRUD.Models;
using PracticeCRUD.ViewModels;

namespace PracticeCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ProductViewModel model , IFormFile imagefile)
        {
            if (imagefile != null && imagefile.Length > 0)
            {
                var fileName = Path.GetFileName(imagefile.FileName);
                var filePath = Path.Combine("wwwroot/Images", fileName);
                using (var stram = new FileStream(filePath, FileMode.Create))
                {
                    imagefile.CopyTo(stram);

                }
                var product = new Product
                {
                    ProductName = model.ProductName,
                    ProductDescription = model.ProductDescription,
                    Price = model.Price,
                    Color = model.Color,
                    image = "/images/" + fileName,

                };
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
                return View();
            }
          return View();

           
        }
        [HttpGet]
        public IActionResult List()
        {
            var product = _dbContext.Products.ToList();
            return View(product);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _dbContext.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(ProductViewModel viewModel, IFormFile imagefile)
        {
            if (imagefile != null && imagefile.Length > 0)
            {
                var fileName = Path.GetFileName(imagefile.FileName);
                var filePath = Path.Combine("wwwroot/Images", fileName);
                using (var stram = new FileStream(filePath, FileMode.Create))
                {
                    imagefile.CopyTo(stram);

                }
                var product = _dbContext.Products.Find(viewModel.Id);
                if (product == null)
                {
                    product.ProductName = viewModel.ProductName;
                    product.ProductDescription = viewModel.ProductDescription;
                    product.Price = viewModel.Price;
                    product.Color = viewModel.Color;
                    product.image = "/images/" + fileName;
                    product.CategoryId = viewModel.CategoryId;
                }
                ;

                _dbContext.SaveChanges();

                return RedirectToAction("List", "Product");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Product viewmodel) 
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == viewmodel.Id);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("List","Product");
        }
    }
}
