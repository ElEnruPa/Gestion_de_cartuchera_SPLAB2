using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Sacapunta : Utiles
    {
        private string color;
        private string material;
        private int id;

        public Sacapunta() : base()
        {
        }

        public Sacapunta(string marca, int precio, string color, string material) : base(marca, precio)
        {
            this.color = color;
            this.material = material;
        }

        public Sacapunta(string marca, int precio, string color, string material, int id) : this(marca, precio, color, material)
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

        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SACAPUNTA:");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Precio: ${Precio}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Material: {Material}");

            return sb.ToString();
        }
    }
}

