using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public class Worker
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
    }
}
