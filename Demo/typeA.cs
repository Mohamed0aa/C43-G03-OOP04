using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class typeA : Itype
    {
        private int mo;
        public int myproperty 
        { 
            get { return mo; } 
            set { mo=value; }
        }

        public void method()
        {
            Console.WriteLine(mo); ;
        }
    }
}
