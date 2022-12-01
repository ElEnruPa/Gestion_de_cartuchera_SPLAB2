using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Utiles
    {
        private protected string marca;
        private protected int precio;

        public Utiles() 
        {
        }

        public Utiles(string marca, int precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public abstract string Marca
        {
            get; set;
        }

        public abstract int Precio
        {
            get; set;
        }

        public abstract string ToString();
    }
}
