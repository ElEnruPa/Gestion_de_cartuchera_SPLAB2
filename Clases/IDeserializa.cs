using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal interface IDeserializa
    {
        Lapiz DeserializaXML();
        Lapiz DeserializaJson();
    }
}
