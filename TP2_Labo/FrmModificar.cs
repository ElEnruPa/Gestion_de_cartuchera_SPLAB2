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
    public partial class FrmModificar : Form
    {
        private int idForm;

        public FrmModificar(Utiles util, int id)
        {
            InitializeComponent();
            idForm = id;
            gbxLapiz.Visible = false;
            gbxGoma.Visible = false;
            gbxSacapunta.Visible = false;


            if (util is Lapiz)
            {
                gbxLapiz.Visible = true;
            }
            else if(util is Goma) 
            {
                gbxGoma.Visible = true;
            }
            else if(util is Sacapunta)
            {
                gbxSacapunta.Visible = true;
            }
        }

        private void btnModificarLapiz_Click(object sender, EventArgs e)
        {
            string marca = txtMarcaLapiz.Text;
            int precio = (int)nupdPrecioLapiz.Value;
            string color = txtColorLapiz.Text;
            string trazo = cbxTrazoLapiz.Text;

            try
            {
                if (marca is null || precio < 1 || color is null || trazo is null)
                {
                    throw new DatosFaltantesException("Faltan datos para poder modificar el util.");
                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que quiere modificar este lapiz?", "MODIFICAR LAPIZ", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Lapiz lapiz = new Lapiz(marca, precio, color, trazo);
                        GestionDB.ActualizarLapiz(lapiz, idForm);
                        limpiarHerramientas();
                        MessageBox.Show("Se modifico el lapiz correctamente.", "MODIFICACION HECHA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnModificarGoma_Click(object sender, EventArgs e)
        {
            string marca = txtMarcaGoma.Text;
            int precio = (int)nupdPrecioGoma.Value;
            string color = txtColorGoma.Text;
            int tamanio = (int)nupdTamanioGoma.Value;

            try
            {
                if (marca is null || precio < 1 || color is null || tamanio < 1)
                {
                    throw new DatosFaltantesException("Faltan datos para poder modificar el util.");
                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que quiere modificar esta goma?", "MODIFICAR GOMA", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Goma goma = new Goma(marca, precio, color, tamanio);
                        GestionDB.ActualizarGomas(goma, idForm);
                        limpiarHerramientas();
                        MessageBox.Show("Se modifico la goma correctamente.", "MODIFICACION HECHA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnModificarSacapunta_Click(object sender, EventArgs e)
        {
            string marca = txtMarcaSacapunta.Text;
            int precio = (int)nupdPrecioSacapunta.Value;
            string color = txtColorSacapunta.Text;
            string material = cbxMateriaSacapunta.Text;

            try
            {
                if (marca is null || precio < 1 || color is null || material is null)
                {
                    throw new DatosFaltantesException("Faltan datos para poder modificar el util.");
                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que quiere modificar este sacapunta?", "MODIFICAR SACAPUNTA", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Sacapunta sacapunta = new Sacapunta(marca, precio, color, material);
                        GestionDB.ActualizarSacapunta(sacapunta, idForm);
                        limpiarHerramientas();
                        MessageBox.Show("Se modifico el sacapunta correctamente.", "MODIFICACION HECHA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
