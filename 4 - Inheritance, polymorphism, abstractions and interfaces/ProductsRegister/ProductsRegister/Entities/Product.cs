﻿using System.Globalization;

namespace ProductsRegister.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}