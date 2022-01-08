using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_BIM_m1_lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rec = new Rectangle();
            Console.WriteLine(Rec.GetArea());
            Console.ReadKey();
        }
    }
    abstract class Figure
    {
        public abstract double GetArea();
        public abstract double GetPrimeter();
        public abstract string name { get; set; }
    }
    class Rectangle : Figure
    {
        public double Width
        { get; set; }
        public double Length
        { get; set; }
        public override string name 
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override double GetArea()
        {
            double S = Width * Length;
            return S;
        }
        public override double GetPrimeter()
        {
            double P = 2 * (Width + Length);
            return P;
        }
    }
}
