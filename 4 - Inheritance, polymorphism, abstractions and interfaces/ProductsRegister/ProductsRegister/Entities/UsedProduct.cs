using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsRegister.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price + " (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")" ;
        }
    }
}
