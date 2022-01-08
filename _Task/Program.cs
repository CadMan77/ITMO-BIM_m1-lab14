using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Pet1 = new Dog("Гафний");
            Pet1.ShowInfo();

            Console.WriteLine();

            Animal Pet2 = new Cat("Мяфний");
            Pet2.ShowInfo();

            Console.ReadKey();
        }
    }
}
