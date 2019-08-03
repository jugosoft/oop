using System.Collections.Generic;

namespace OOP_Basics
{
    public interface IShopable
    {
        void AddGood(ITradable good);
        void AddWorker(IWorkable worker);
        IList<ITradable> GetGoods();
        IList<IWorkable> GetWorkers();
    }
}