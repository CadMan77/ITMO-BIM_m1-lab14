using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Task
{
    public class Dog : Animal
    {
        private string name;
        public override string Name
        {
            set => name = value;
            get => name;
        }

        public Dog(string name)
            :base(name)
        {
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
