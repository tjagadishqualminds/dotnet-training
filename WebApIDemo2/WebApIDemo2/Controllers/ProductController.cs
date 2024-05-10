using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApIDemo2.Model;

namespace WebApIDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private List<ProductModel> addProducts()
        {
            List<ProductModel> products = new List<ProductModel>();    
            ProductModel model = new ProductModel { 
            id = 1,
            Name = "Test",
            price=1232
            };
            ProductModel model2 = new ProductModel
            {
                id = 2,
                Name = "Test",
                price = 34
            };
            products.Add(model);
            products.Add(model2);

            return products;
           
        }


        [HttpGet("/Display")]
        public IEnumerable<ProductModel> Get()
        {
             return addProducts();
        }

        [HttpGet("/DisplayString")]
        public string GetString()
        {
            return "jagadish";
        }

    }



}
