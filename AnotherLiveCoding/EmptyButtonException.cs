using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class EmptyButtonException : Exception
    {
        public EmptyButtonException(string message) : base(message)
        {

        }
    }
}
