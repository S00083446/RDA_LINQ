using System;
using System.Linq;

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

        //3 - List Products with Quantity <= 100
        Console.WriteLine("\nQuestion 3");

        var query = pModel.Products.Where(p => p.QuantityInStock <= 100);
        foreach (var item in query)
        {
            Console.WriteLine(item);
        }

        //4 - List all Products together with their total value
        Console.WriteLine("\nQuestion 4");

        float totalPrice;
        foreach (var item in pModel.Products)
        {
            Console.WriteLine(item);
            totalPrice = item.UnitPrice * item.QuantityInStock;
            Console.Write("Total: {0:c}\n", totalPrice);
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
        var suppliers = (from s in pModel.Suppliers
                            join sp in pModel.SupplierProducts
                            on s.SupplierID equals sp.SupplierID
                            join p in pModel.Products
                            on sp.ProductID equals p.ProductID
                            select new
                            {   s.SupplierName,
                                p.Description
                            }).OrderBy(o => o.SupplierName);
        foreach (var item in suppliers)
        {
            Console.WriteLine("Supllier name: " + item.SupplierName + "\t\tParts: " + item.Description);
        }

        Console.ReadKey();
    }
}
}
