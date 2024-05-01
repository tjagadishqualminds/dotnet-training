using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    internal class Operations
    {
        //Create an instance of ProductOperation
        ProductOperation productOperation= new ProductOperation();
        //Create an instance of ProductModal
        ProductModal productModal = new ProductModal();

        //Add new Product to the list
        public void AddProduct()
        {
            try
            {
                Console.WriteLine("Add Product");
                Console.WriteLine("Enter new Product Id");
                int prodid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new Product Name");
                string prodname = Console.ReadLine();
                Console.WriteLine("Enter new Product Description");
                string proddesc = Console.ReadLine();
                Console.WriteLine("Enter new Product Price");
                decimal prodprice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter new Product Image");
                string prodimage = Console.ReadLine();
                //create a new ProductModal object and set its properties
                ProductModal productModal = new ProductModal();
           
                productModal.ProdName = prodname;
                productModal.ProdId = prodid;
                productModal.ProdDescription = proddesc;
                productModal.ProdPrice = prodprice;
                productModal.Prodimage = prodimage;
               
                //add the ProductModat object to the List
               if(productOperation.AddProduct(productModal))
                {
                    Console.WriteLine("Products added sucessfully");
                }
               else
                {
                    Console.WriteLine("Entered invalid id ");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Display all Products in the list
        public void ShowAllProducts() {

            List<ProductModal> products = productOperation.ShowAllProduct();
            foreach (ProductModal prod in products)
            {
                Console.WriteLine($"ProductId : {prod.ProdId} ,ProductName : {prod.ProdName},ProductDescription : {prod.ProdDescription}, ProductPrice : {prod.ProdPrice},ProductImage: {prod.Prodimage}");
            }
        }

        //Display a single product based on its ProdId
        public void ShowSingleProduct()
        {
            Console.WriteLine("Enter product id to get product details");
            try
            {

                int prodId = int.Parse(Console.ReadLine());
                ProductModal product = productOperation.ShowSingleProduct(prodId);
                if (product != null)
                {
                    Console.WriteLine($"ProductId : {product.ProdId} ,ProductName : {product.ProdName},ProductDescription : {product.ProdDescription}, ProductPrice : {product.ProdPrice},ProductImage: {product.Prodimage}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        //Delete a product from the list based on its prodid
        public void DeleteProduct()
        {
            try
            {
                Console.WriteLine("Enter id for deleting producting");
                int prodiddelete = int.Parse(Console.ReadLine());
                if (productOperation.DeleteProduct(prodiddelete))
                {
                    Console.WriteLine($"product details deleted  id {prodiddelete}");

                }
                else
                {
                    Console.WriteLine($"deleted id not found {prodiddelete}");
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message );
            }
        }


        //Update  a product in the list based on its prodid
        public void UpdateProduct()
        {
           

            try
            {
                Console.WriteLine("Enter product id for updating product name and product price");
                int produpid = int.Parse (Console.ReadLine());
              var str =  productOperation.ShowSingleProduct(produpid);
                if (str != null)
                {
                    Console.WriteLine("Enter new product name");
                    string upname = Console.ReadLine();
                    Console.WriteLine("Enter new product price");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new image prdocut");
                    string imageprod = Console.ReadLine();
                    Console.WriteLine("Enter new description");
                    string descprdod = Console.ReadLine();
                    productModal.ProdName = upname;
                    productModal.ProdId = produpid;
                    productModal.ProdPrice = price;
                    productModal.Prodimage = imageprod;
                    productModal.ProdDescription = descprdod;
                   if( productOperation.UpdatedProductTwo(produpid, productModal))
                    {
                            Console.WriteLine("Updated successfully");
                    }
                    else { 
                            Console.WriteLine("id not found");
                    
                    }
                }
            }
            catch (FormatException ex) 
            {

                Console.WriteLine(ex.Message); 
            }
        }

    } 
}
