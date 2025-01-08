using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius = {Radius} \narea  = {3.14*Radius* Radius}\n circumference = {2*3.14*Radius}");
        }
    }
}
