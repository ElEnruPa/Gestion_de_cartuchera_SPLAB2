using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal interface IDeserializa<T> where T : Utiles
    {
        Utiles DeserializaXML();
        Utiles DeserializaJson();
    }
}
