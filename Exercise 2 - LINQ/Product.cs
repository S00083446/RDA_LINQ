using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___LINQ
{
    class Product
    {
        public int ProductID { get; set; }
        public String Description { get; set; }
        public int QuantityInStock { get; set; }
        public float UnitPrice{ get; set; }
        public int CategoryID { get; set; }

        public override string ToString()
        {
            return string.Format(Description);

        }

    }
}
