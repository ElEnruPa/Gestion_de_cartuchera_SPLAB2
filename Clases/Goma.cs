using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Goma : Utiles
    {
        private string color;
        private int tamanio;
        private int id;

        public Goma() : base()
        {
        }

        public Goma(string marca, int precio, string color, int tamanio) : base(marca, precio)
        {
            this.color = color;
            this.tamanio = tamanio;
        }

        public Goma(string marca, int precio, string color, int tamanio, int id) : this(marca, precio, color, tamanio)
        {
            this.id = id;
        }

        public int Id { get => this.id; }

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

        public int Tamanio
        {
            get { return this.tamanio; }
            set { this.tamanio = value; }
        }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("GOMA:");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Precio: ${Precio}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Tamaño: {Tamanio}cm");

            return sb.ToString();
        }
    }
}
