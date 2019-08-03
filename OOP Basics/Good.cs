using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public abstract class Good : ITradable
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public Good(int price, string brand, string name)
        {
            Price = price;
            Brand = brand;
            Name = name;
        }

        public override string ToString()
        {
            return "Brand " + Brand + " Name " + Name + " Price " + Price;
        }
    }
}
