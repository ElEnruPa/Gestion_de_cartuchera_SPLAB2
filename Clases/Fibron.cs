using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases
{
    public class Fibron : Utiles, ISerializa<Utiles>, IDeserializa<Utiles>
    {
        private string color;
        private int cantidadTinta;
        private int id;
        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Fibron() : base()
        {
        }

        public Fibron(string marca, int precio, string color, int cantidaTinta) : base(marca, precio)
        {
            this.color = color;
            this.cantidadTinta = cantidaTinta;
        }

        public Fibron(string marca, int precio, string color, int cantidadTinta, int id) : this(marca, precio, color, cantidadTinta)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }

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

        public void SerializaXML()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{ruta}\\fibron.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

                    xmlSerializer.Serialize(sw, this);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Utiles DeserializaXML()
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{ruta}\\fibron.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

                    Fibron fibron = xmlSerializer.Deserialize(sr) as Fibron;

                    return fibron;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SerializaJson()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(this);
                File.WriteAllText($"{ruta}\\fibron.json", jsonString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Utiles DeserializaJson()
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{ruta}\\fibron.json"))
                {
                    string json = File.ReadAllText($"{ruta}\\fibron.json");
                    Fibron fibron = JsonSerializer.Deserialize<Fibron>(json);
                    return fibron;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
