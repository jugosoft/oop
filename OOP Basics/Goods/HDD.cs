using System;

namespace OOP_Basics.Goods
{
    class HDD : Good
    {
        private bool formatted;
        public int Volume { get; private set; }

        public HDD(int price, string brand, string name, int volume) : base(price, brand, name)
        {
            if (volume <= 0)
            {
                throw new Exception();
            }

            formatted = true;
            Volume = volume;
        }

        public void Format()
        {
            formatted = true;
        }

        public void WriteInfo()
        {
            formatted = false;
        }

        public override string ToString()
        {
            string str = base.ToString();

            return "HDD " + str + ", but Volume " + Volume;
        }
    }
}
