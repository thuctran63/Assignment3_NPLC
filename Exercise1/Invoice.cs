using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Exercise1
{
    class Invoice : Interface
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public double PricePerItem { get; set; }

        public double GetPaymentAmount()
        {
            return 0.0;
        }


    }
}
