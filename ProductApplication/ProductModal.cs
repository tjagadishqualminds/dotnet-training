using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    internal class ProductModal
    {
        //declaration of fields
        private int prodid;
        private string prodname;
        private string proddescription;
        private decimal prodprice;
        private string prodimage;

        //properties
        public int  ProdId { get { return prodid; } set { prodid = value; } }
       public string ProdName { get { return prodname; } set { prodname = value; } }
        public string ProdDescription { get {  return proddescription; } set {  proddescription = value; } }
        public decimal ProdPrice { get { return prodprice; } set { prodprice = value; } }
        public string Prodimage { get {  return prodimage; } set { prodimage = value; } }
    }
}
