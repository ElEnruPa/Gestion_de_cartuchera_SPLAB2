using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class DatosFaltantesException : Exception
    {
        public DatosFaltantesException(string mensaje) : this (mensaje, null)
        {

        }

        public DatosFaltantesException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
