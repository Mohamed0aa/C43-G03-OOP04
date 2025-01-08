using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface Itype
    {
        //public access modifier is defulte 
        //private is not allow


        //what i can write on interface

        //1-property signature
        int myproperty {  get; set; }


        //2-method signature
            void method ();
        //3- defulte implemmented method c# 8 new feature  net core 3.1
        void method1() { Console.WriteLine("moali"); }


        //4-static method
    }
}
