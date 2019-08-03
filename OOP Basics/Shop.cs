using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public class Shop
    {
        private IList<Good> goods;
        private IList<Worker> workers;
        private string name;

        public Shop(string name)
        {
            if (name == null || name == "")
            {
                throw new Exception();
            }

            this.name = name;

            goods = new List<Good>();
            workers = new List<Worker>();
        }

        public string GetName()
            => this.name;

        public void AddGood(Good good)
        {
            if (good != null)
            {
                goods.Add(good);
            }
        }

        public void AddWorker(Worker worker)
        {
            if (worker != null)
            {
                workers.Add(worker);
            }
        }

        public IList<Good> GetGoods()
        {
            return goods;
        }

        public IList<Worker> GetWorkers()
        {
            return workers;
        }
    }
}
