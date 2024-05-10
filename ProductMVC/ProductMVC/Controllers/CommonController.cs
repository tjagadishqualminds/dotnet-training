using Microsoft.AspNetCore.Mvc;
using ProductMVC.Models;

namespace ProductMVC.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<ProductModel> AddProduct()
        {
            List<ProductModel> products = new List<ProductModel>();
            ProductModel model = new ProductModel { 
            Id = 1,
            Name = "Test",
            price=123,
            };
            ProductModel model2 = new ProductModel
            {
                Id = 2,
                Name = "Test2",
                price = 1232,
            };
            products.Add(model);
            products.Add(model2);
            return products;
        }


  


        public List<CategoryModel> AddCategory()
        {
            List<CategoryModel> categories = new List<CategoryModel>();
            CategoryModel category = new CategoryModel
            {
              categoryId = 1,
              categoryName = "Test",
              categroyPrice=1232,
            };
            CategoryModel category2 = new CategoryModel
            {
                categoryId = 1,
                categoryName = "Test",
                categroyPrice = 1232,
            };
           categories.Add(category);
            categories.Add(category2);
            return categories;
        }


   


        public ViewResult CommonDisplay()
        {
            List<CategoryModel> categoryModels = AddCategory();
            List<ProductModel> productModels = AddProduct();


            Common common = new Common {
                Categories = categoryModels,
                Products=  productModels,
            
            
            };   
            return View(common);
           
        }

    }
}
