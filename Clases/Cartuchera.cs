using System.Text;

namespace Clases
{
    public class Cartuchera<T> where T : Utiles
    {
        public delegate void DelegadoPrecio (Cartuchera<T> sender);
        public event DelegadoPrecio EventoPrecio;

        private int capacidad;
        private List<T> listaElementos;

        public Cartuchera()
        {
            listaElementos = new List<T>();
        }

        public Cartuchera(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public int Capacidad
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }
        }

        public List<T> ListaElementos { get => listaElementos; set => listaElementos = value; }

        public float precioTotal
        {
            get
            {
                float suma = 0.0f;

                foreach (T util in this.listaElementos)
                {
                    suma += util.Precio;
                }

                return suma;
            }

            //set { throw new NotImplementedException(); }
        }

        public static bool operator +(Cartuchera<T> cartuchera, T util)
        {
            bool result = false;
            try
            {
                if (cartuchera.listaElementos.Count < cartuchera.Capacidad)
                {
                    cartuchera.listaElementos.Add(util);
                    result = true;

                    if(cartuchera.precioTotal > 500 && cartuchera.EventoPrecio is not null)
                    {
                        cartuchera.EventoPrecio(cartuchera);
                    }
                }
                else
                {
                    throw new CartucheraLlenaException("La cartuchera esta llena, no se pueden agregar mas utiles.");
                }
            }
            catch (CartucheraLlenaException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T util in this.listaElementos)
            {
                sb.AppendLine(util.ToString());
            }

            return sb.ToString();
        }
    }
}