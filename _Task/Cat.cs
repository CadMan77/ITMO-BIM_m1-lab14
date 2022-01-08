﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Task
{
    public class Cat : Animal
    {
        private string name;
        public override string Name
        {
            set => name = value;
            get => name;
        }
        public Cat(string name)
            :base (name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
