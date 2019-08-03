using OOP_Basics;
using OOP_Basics.Goods;

namespace OOP
{
    class Program
    {
        public static void Main()
        {
            Shop shop = new Shop("SomeStore");

            Worker worker1 = new Worker("Larisa", 28);
            Worker worker2 = new Worker("Klarisa", 21);
            shop.AddWorker(worker1);
            shop.AddWorker(worker2);

            Good tv1 = new TV(5000, "LG", "228K");
            Good tv2 = new TV(5000, "SAmsung", "13TGR37");
            Good laptop1 = new Laptop(228000, "Apple", "Makbook 20 late");
            Good laptop2 = new Laptop(228000, "Apple", "Makbook 21 early");
            Good laptop3 = new Laptop(228000, "Apple", "Makbook 22 late");
            Good hdd = new HDD(1234, "Toshiba", "Don't have any idea...", 500);
            shop.AddGood(tv1);
            shop.AddGood(tv2);
            shop.AddGood(laptop1);
            shop.AddGood(laptop2);
            shop.AddGood(laptop3);
            shop.AddGood(hdd);

            System.Console.WriteLine("Goods: ");
            foreach (var item in shop.GetGoods())
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Workers (IWorkable): ");
            foreach (var item in shop.GetWorkers())
            {
                System.Console.WriteLine(item);
            }

            System.Console.ReadLine();
        }
    }
}
