using System;
using System.Collections.Generic;

namespace OOP_Basics
{
    public class Shop : IShopable
    {
        private IList<ITradable> goods;
        private IList<IWorkable> workers;
        private string name;

        public Shop(string name)
        {
            if (name == null || name == "")
            {
                throw new Exception();
            }

            this.name = name;

            goods = new List<ITradable>();
            workers = new List<IWorkable>();
        }

        public string GetName()
            => this.name;

        public void AddGood(ITradable good)
        {
            if (good != null)
            {
                goods.Add(good);
            }
        }

        public void AddWorker(IWorkable worker)
        {
            if (worker != null)
            {
                workers.Add(worker);
            }
        }

        public IList<ITradable> GetGoods()
        {
            return goods;
        }

        public IList<IWorkable> GetWorkers()
        {
            return workers;
        }
    }
}
