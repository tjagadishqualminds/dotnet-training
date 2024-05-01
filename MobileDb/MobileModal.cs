using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDb
{
    internal class MobileModal
    {
        //declaration of fields
        private int mobileid;
        private string mobilename;
        private decimal mobileprice;

        //properties
        public MobileModal() { }
        public int MobileId {  get; set; }
        public string MobileName { get; set; }
        public decimal MobilePrice { get; set; }

    }
}
