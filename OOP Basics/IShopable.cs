namespace OOP_Basics
{
    public interface IShopable
    {
        void AddGood(ITradable good);
        void AddWorker(IWorkable worker);
    }
}