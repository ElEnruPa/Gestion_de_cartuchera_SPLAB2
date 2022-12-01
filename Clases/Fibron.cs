using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Fibron : Utiles
    {
        private string color;
        private int cantidadTinta;

        public Fibron(string marca, int precio, string color, int cantidaTinta) : base(marca, precio)
        {
            this.color = color;
            this.cantidadTinta = cantidaTinta;
        }

        public override string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public override int Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int CantidadTinta
        {
            get { return this.cantidadTinta; }
            set { this.cantidadTinta = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("FIBRON:");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Precio: ${Precio}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Cantidad Tinta: {CantidadTinta}");

            return sb.ToString();
        }

        public void Resaltar(int cantidad)
        {
            if(cantidad > this.cantidadTinta)
            {
                throw new SinTintaException("El fibron no tiene tinta suficiente.");
            }
            else
            {
                this.cantidadTinta -= cantidad;
            }
        }
    }
}
