using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmMenuAgregar : Form
    {
        private Cartuchera<Utiles> cartucheraForm;

        public FrmMenuAgregar(Cartuchera<Utiles> cartucheraNueva)
        {
            InitializeComponent();
            cartucheraForm = cartucheraNueva;
            this.lblCapacidadActual.Text = $"La capacidad actual de la cartuchera es: {cartucheraForm.Capacidad}";
        }

        private void FrmMenuAgregar_Load(object sender, EventArgs e)
        {
            cartucheraForm.EventoPrecio += creacionTicket;
        }

        private void btnAgregarLapiz_Click(object sender, EventArgs e)
        {
            string marca = txtMarcaLapiz.Text;
            int precio = (int)nupdPrecioLapiz.Value;
            string color = txtColorLapiz.Text;
            string trazo = cbxTrazoLapiz.Text;

            try
            {
                if(marca is null || precio < 1 || color is null || trazo is null) 
                {
                    throw new DatosFaltantesException("Faltan datos para poder agregar el util.");
                }
                else
                {
                    if(MessageBox.Show("¿Estas seguro que quiere agregar este lapiz a la cartuchera?", "AGREGAR LAPIZ", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Lapiz lapiz = new Lapiz(marca, precio, color, trazo);
                        _ = cartucheraForm + lapiz;
                        GestionDB.AltaLapiz(lapiz);
                        limpiarHerramientas();
                        MessageBox.Show("Se agrego el lapiz correctamente.", "LAPIZ AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (DatosFaltantesException ex)
            {
                MessageBox.Show(ex.Message, "DATOS FALTANTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregarGoma_Click(object sender, EventArgs e)
        {
            string marca = txtMarcaGoma.Text;
            int precio = (int)nupdPrecioGoma.Value;
            string color = txtColorGoma.Text;
            int tamanio = (int)nupdTamanioGoma.Value;

            try
            {
                if (marca is null || precio < 1 || color is null || tamanio < 1)
                {
                    throw new DatosFaltantesException("Faltan datos para poder agregar el util.");
                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que quiere agregar esta goma a la cartuchera?", "AGREGAR GOMA", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Goma goma = new Goma(marca, precio, color, tamanio);
                        _ = cartucheraForm + goma;
                        GestionDB.AltaGoma(goma);
                        limpiarHerramientas();
                        MessageBox.Show("Se agrego la goma correctamente.", "GOMA AGREGADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (DatosFaltantesException ex)
            {
                MessageBox.Show(ex.Message, "DATOS FALTANTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarSacapunta_Click(object sender, EventArgs e)
        {
            string marca = txtMarcaSacapunta.Text;
            int precio = (int)nupdPrecioSacapunta.Value;
            string color = txtColorSacapunta.Text;
            string material = cbxMateriaSacapunta.Text;
            
            try
            {
                if (marca is null || precio < 1 || color is null || material is null)
                {
                    throw new DatosFaltantesException("Faltan datos para poder agregar el util.");
                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que quiere agregar este sacapunta a la cartuchera?", "AGREGAR SACAPUNTA", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Sacapunta sacapunta = new Sacapunta(marca, precio, color, material);
                        _ = cartucheraForm + sacapunta;
                        GestionDB.AltaSacapunta(sacapunta);
                        limpiarHerramientas();
                        MessageBox.Show("Se agrego el sacapunta correctamente.", "SACAPUNTA AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (DatosFaltantesException ex)
            {
                MessageBox.Show(ex.Message, "DATOS FALTANTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarCapacidad_Click(object sender, EventArgs e)
        {
            int nuevaCapacidad = (int)nupdCapacidad.Value;
            if(cartucheraForm.ListaElementos.Count > nuevaCapacidad)
            {
                MessageBox.Show("No se puede ingresar esta capacidad porque es menor a los utiles que hay actualmente en esta.",
                    "CAPACIDAD INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cartucheraForm.Capacidad = nuevaCapacidad;
                MessageBox.Show("Se cambio la capacidad de la cartuchera correctamente.", "CAMBIO DE CAPACIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nupdCapacidad.Value = 1;
            }
        }

        private void limpiarHerramientas()
        {
            txtMarcaLapiz.Clear();
            txtMarcaGoma.Clear();
            txtMarcaSacapunta.Clear();
            nupdPrecioLapiz.Value = 0;
            nupdPrecioGoma.Value = 0;
            nupdPrecioSacapunta.Value = 0;
            txtColorLapiz.Clear();
            txtColorGoma.Clear();
            txtColorSacapunta.Clear();
            cbxTrazoLapiz.SelectedIndex = -1;
            nupdTamanioGoma.Value = 1;
            cbxMateriaSacapunta.SelectedIndex = -1;
            txtMarcaFibron.Clear();
            nupdPrecioFibron.Value = 0;
            txtColorFibron.Clear();
            nupdCantidadTinta.Value = 1;
        }

        public void creacionTicket(Cartuchera<Utiles> cartuchera)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string evento = string.Empty;

            using(StreamWriter sw = new StreamWriter($"{ruta}\\tickets.log"))
            {
                sw.WriteLine("Cartuchera:");
                sw.WriteLine($"Precio total: {cartuchera.precioTotal}");
                sw.WriteLine("");

                foreach (Utiles util in cartuchera.ListaElementos)
                {
                    sw.WriteLine(util.ToString());
                }
            }

            MessageBox.Show(evento.EscuchandoEvento(),"ESCUCHANDO EL EVENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarFibron_Click(object sender, EventArgs e)
        {
            string marca = txtMarcaFibron.Text;
            int precio = (int)nupdPrecioFibron.Value;
            string color = txtColorFibron.Text;
            int cantidadTinta = (int)nupdCantidadTinta.Value;

            try
            {
                if (marca is null || precio < 1 || color is null || cantidadTinta < 1)
                {
                    throw new DatosFaltantesException("Faltan datos para poder agregar el util.");
                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que quiere agregar este fibron a la cartuchera?", "AGREGAR FIBRON", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Fibron fibron = new Fibron(marca, precio, color, cantidadTinta);
                        _ = cartucheraForm + fibron;
                        GestionDB.AltaFibron(fibron);
                        limpiarHerramientas();
                        MessageBox.Show("Se agrego el fibron correctamente.", "FIBRON AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (DatosFaltantesException ex)
            {
                MessageBox.Show(ex.Message, "DATOS FALTANTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
