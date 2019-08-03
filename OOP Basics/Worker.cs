namespace OOP_Basics
{
    public class Worker : IWorkable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Worker(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DoWork()
        {

        }

        public override string ToString()
        {
            return "Worker " + Name + ". Age " + Age + ".";
        }
    }
}
