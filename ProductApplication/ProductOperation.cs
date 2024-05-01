using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
   internal class ProductOperation
    {
        //Declare a list of ProductModal objects
        List<ProductModal> prod = new List<ProductModal>();

        //Add a new product to the list
       public bool AddProduct(ProductModal prods)
        {
            if (!prod.Any(p => p.ProdId == prods.ProdId)){

                prod.Add(prods);
                return true;
            }
            return false;
           
        }
        //modified by for adding unique products

        //Return the entire list of products
        public List<ProductModal> ShowAllProduct()
        {
           return prod;
        }
        
   

        //Return a single product based on its prodid
        public ProductModal ShowSingleProduct(int prodid)
        {
            int index = prod.FindIndex(P=>P.ProdId == prodid);
            ProductModal productModal = prod[index];
            return productModal;
        }

     

        //Remove a product from the list based on its Prodid
        public bool DeleteProduct (int prodid)
        {
           int index = prod.FindIndex(p=>p.ProdId == prodid);
            if(index !=-1)
            {
                prod.RemoveAt(index);
                return true;
            }
        return false;
        }



        //update a product in the list based on its prodid
        public bool UpdatedProductTwo(int updid,ProductModal newproduct)
        {
            int index = prod.FindIndex(p=>p.ProdId==updid);
            if(index !=-1)
            {
                prod[index]=newproduct;
                return true;
            }
         return false ;

        }

    }
}
