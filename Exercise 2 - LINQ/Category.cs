using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___LINQ
{
    class Category
    {
        public int id { get; set; }
        public String Description { get; set; }

        public override string ToString()
        {
            return string.Format(Description); 
        }
    }
}
