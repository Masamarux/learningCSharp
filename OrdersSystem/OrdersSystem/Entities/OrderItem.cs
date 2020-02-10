using System.Text;
using System.Globalization;
using OrdersSystem.Entities;

namespace OrdersSystem.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, string name)
        {
            Quantity = quantity;
            Price = price;
            Product = new Product(name, price);
            //prices are 2 because we need to store the past price(maybe from a sale or not) and a currently price
        }
        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", R$ ");
            sb.Append(Price);
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: R$ ");
            sb.Append(SubTotal().ToString("f2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
