using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using PracticeCRUD.Data;
using PracticeCRUD.Models;
using PracticeCRUD.ViewModels;

namespace PracticeCRUD.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext dbContext) 
        {
            this._context = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(CategoryViewModel viewModel)
        {
            var category = new Category
            {
                CategoryName = viewModel.CategoryName,
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult List() 
        {
            var category = _context.Categories.ToList();
            return View(category);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category viewModel)
        {
            var category = _context.Categories.Find(viewModel.CategoryId);
            if (category != null) 
            {
                category.CategoryId = viewModel.CategoryId;
                category.CategoryName = viewModel.CategoryName;

            }
            _context.SaveChanges();
            return RedirectToAction("List","Category");
        }
        [HttpPost]
        public IActionResult Delete(Category viewmodel) 
        {
            var category = _context.Categories.FirstOrDefault(x=>x.CategoryId == viewmodel.CategoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }

            return RedirectToAction("List", "Category");
        }

    }
}
