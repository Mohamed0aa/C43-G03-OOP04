using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface Iseries
    {
        public int  current {  get; set; }

        public void get_next();
        public void reset( );
    }
}
