using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class airplane :Imovable,Iflayable
    {
        public int speed { get; set; }

        void Imovable.backward()
        {
            throw new NotImplementedException();
        }

        void Iflayable.backward()
        {
            throw new NotImplementedException();
        }

        void Imovable.forward()
        {
            throw new NotImplementedException();
        }

        void Iflayable.forward()
        {
            throw new NotImplementedException();
        }

        void Imovable.left()
        {
            throw new NotImplementedException();
        }

        void Iflayable.left()
        {
            throw new NotImplementedException();
        }

        void Imovable.right()
        {
            throw new NotImplementedException();
        }

        void Iflayable.right()
        {
            throw new NotImplementedException();
        }
    }
}
