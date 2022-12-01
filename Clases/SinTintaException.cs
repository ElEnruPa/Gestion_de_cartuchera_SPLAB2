using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class SinTintaException : Exception
    {
        public SinTintaException(string mensaje) : this(mensaje, null)
        {
        }

        public SinTintaException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
