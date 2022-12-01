using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class StringExtension
    {
        public static string EscuchandoEvento(this String str) 
        {
            return "Se escucho el evento.";
        }

        public static int ContarCaracteres(this String str)
        {
            int contador = 0;

            foreach (char c in str)
            {
                contador++;
            }

            return contador;
        }
    }
}
