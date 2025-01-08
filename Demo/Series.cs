using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Series : Iseries
    {
        public int current { get; set; }

        public void get_next()
        {
            current+=2;
        }

        public void reset()
        {
            current=0;
        }
    }
}
