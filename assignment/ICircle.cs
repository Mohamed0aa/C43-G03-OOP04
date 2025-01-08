using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal interface ICircle : Ishap
    {
        public double area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayShapeInfo()
        {
            throw new NotImplementedException();
        }
    }
}
