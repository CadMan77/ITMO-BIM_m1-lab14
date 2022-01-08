using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Task
{
    public abstract class Animal
    {
        public abstract string Name { get; set; } // название (кличка) животного
  
        public Animal(string name) 
        {
            Name = name;
        }

        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write($"{Name}: ");
            Say();
        }
    }
}
