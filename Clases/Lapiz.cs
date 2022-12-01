using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases
{
    public class Lapiz : Utiles, ISerializa<Utiles>, IDeserializa<Utiles>
    {
        private string color;
        private string trazo;
        private int id;
        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Lapiz() : base()
        {
        }

        public Lapiz(string marca, int precio, string color, string trazo) : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public Lapiz(string marca, int precio, string color, string trazo, int id) : this (marca, precio, color, trazo)
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

        public string Trazo
        {
            get { return this.trazo; }
            set { this.trazo = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LAPIZ:");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Precio: ${Precio}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Trazo: {Trazo}");

            return sb.ToString();
        }

        public void SerializaXML()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{ruta}\\lapiz.xml"))
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
                using (StreamReader sr = new StreamReader($"{ruta}\\lapiz.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

                    Lapiz lapiz = xmlSerializer.Deserialize(sr) as Lapiz;

                    return lapiz;
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
                File.WriteAllText($"{ruta}\\lapiz.json", jsonString);
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
                using (StreamReader sr = new StreamReader($"{ruta}\\lapiz.json"))
                {
                    string json = File.ReadAllText($"{ruta}\\lapiz.json");
                    Lapiz lapiz = JsonSerializer.Deserialize<Lapiz>(json);
                    return lapiz;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
