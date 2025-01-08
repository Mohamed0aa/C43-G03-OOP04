using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Rectangle : IRectangle
    {
       public double width {  get; set; }
       public double height {  get; set; }
        public double area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"width = {width} , hight = {height} \narea  = {width*height}\n circumference = {2 *( width+height)}");
        }
    }
}
