using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException(string mensaje) : this(mensaje, null)
        {
        }

        public CartucheraLlenaException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
