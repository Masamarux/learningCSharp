using System;
using OrdersSystem.Entities;
using OrdersSystem.Entities.Enums;
using System.Globalization;

namespace OrdersSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //there are some errors like writing the status with a minor change etc
            int manyItems, qntProd;
            double price;
            string name, email, nameProd;
            DateTime birth;
            OrderStatus status;

            Client client;
            Order order;
            OrderItem orderItem;

            Console.WriteLine("Enter Client data:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth date(DD/MM/YYYY): ");
            birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());

            client = new Client(name, email, birth);
            order = new Order(status, client);

            Console.Write("How many items to this order? ");
            manyItems = int.Parse(Console.ReadLine());

            for(int i = 0; i < manyItems; i++)
            {
                nameProd = "";
                price = 0.00;
                qntProd = 0;

                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                qntProd = int.Parse(Console.ReadLine());

                orderItem = new OrderItem(qntProd, price, nameProd);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.Write(order);
        }
    }
}
