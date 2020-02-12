using System;
using System.Globalization;
using System.Collections.Generic;
using ProductsRegister.Entities;

namespace ProductsRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            char type;
            string name;
            double price, customsFee;
            DateTime date;
            List<Product> productList = new List<Product>();

            Console.Write("Enter the number of products: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i' || type == 'I')
                {
                    Console.Write("Customs fee: ");
                    customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    productList.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type == 'u' || type == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    date = DateTime.Parse(Console.ReadLine());
                    productList.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    productList.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product p in productList)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
