using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics.Goods
{
    class Laptop : Good
    {
        private bool turnedOn;

        public Laptop(int price, string brand, string name) : base(price, brand, name)
        {
            turnedOn = false;
        }

        public void SwitchState()
        {
            turnedOn = !turnedOn;
        }

        public bool GetState()
            => turnedOn;

        public override string ToString()
        {
            string str = base.ToString();

            return "Laptop " + str + ", but Turned ON " + turnedOn;
        }
    }
}
