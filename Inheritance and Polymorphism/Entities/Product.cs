﻿using System.Globalization;

namespace Inheritance_and_Polymorphism.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name, double price) 
        {
            Name = name;
            Price = price;
        }

        virtual public string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
