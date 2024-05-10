using Microsoft.AspNetCore.Mvc;
using WebApiCrud.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
      
     static List<ProductModel> products;

        static ProductController()
        {
            products = new List<ProductModel>();
        }

     
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ProductModel Get(int id)
        {
            ProductModel model = products.Find(x=>x.Id==id);
            if (model != null)
            {
                return model;
            }
            return null;
            
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] ProductModel productModel) {
            products.Add(productModel);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ProductModel Put(int id, [FromBody] ProductModel productModel)
        {
            ProductModel model = products.Find(x=>x.Id==id);
            if (model != null)
            {
                model.Name = productModel.Name;
                model.Price = productModel.Price;
                return model;
            }
            return null;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ProductModel model = products.Find(x => x.Id == id);
            if (model != null)
            {
               products.Remove(model);
            }
        

        }
    }
}
