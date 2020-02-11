using System.Globalization;

namespace ProductsRegister.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("f2", CultureInfo.InvariantCulture) + " (Fee: $" + CustomsFee + ")";
        }
    }
}
