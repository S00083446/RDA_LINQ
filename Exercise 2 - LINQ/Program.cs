using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUERIES
            //1 - List all categories
            Console.WriteLine("Question 1:");

            ProductModel pModel = new ProductModel();
            
            foreach (var item in pModel.Categories)
            {
                Console.WriteLine(item);
            }

            //2 -  List all the Products
            Console.WriteLine("\nQuestion 2");
            foreach (var item in pModel.Products)
            {
                Console.WriteLine(item);
            }

            //3 - List Products with Quantity <= 200
            Console.WriteLine("\nQuestion 3");

            var query = pModel.Products.Where(p => p.QuantityInStock <= 100);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            //4 - List all Products together with their total value
            Console.WriteLine("\nQuestion 4");

            float totalPrice;
            var total = pModel.Products.Sum(s => s.UnitPrice);
            foreach (var item in pModel.Products)
            {
                Console.WriteLine(item);
                totalPrice = item.UnitPrice * item.QuantityInStock;
                Console.Write("Total: {0:f}\n", totalPrice);
            }


            //5 - List all the Products in the Hardware Category
            Console.WriteLine("\nQuestion 5");

            var query5 = from c in pModel.Categories
                        join p in pModel.Products
                        on c.id equals p.CategoryID
                        where c.Description == "Hardware"
                        select p;

            foreach (var item in query5)
            {
                Console.WriteLine(item);
            }

            // 6 - List all the suppliers and their Parts oredred by supplier name
            Console.WriteLine("\nQuestion 6");


        }
    }
}
