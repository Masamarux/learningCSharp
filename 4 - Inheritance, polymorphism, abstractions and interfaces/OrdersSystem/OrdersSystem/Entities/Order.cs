using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using OrdersSystem.Entities;
using OrdersSystem.Entities.Enums;

namespace OrdersSystem.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
            Date = DateTime.Now;
        }
        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }
        public double Total()
        {
            double total = 0.00;
            foreach(OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: ");
            sb.AppendLine(Total().ToString("f2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
