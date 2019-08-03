namespace OOP_Basics.Goods
{
    class TV : Good
    {
        private bool turnedOn;

        public TV(int price, string brand, string name) : base(price, brand, name)
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

            return "TV " + str + ", but Turned ON " + turnedOn;
        }
    }
}
