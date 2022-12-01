using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal interface ISerializa<T> where T : Utiles
    {
        void SerializaXML();
        void SerializaJson();
    }
}
