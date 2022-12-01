using Clases;
using Formularios;

namespace TP2_Labo
{
    public partial class FrmPrincipal : Form
    {
        private Cartuchera<Utiles> cartucheraNueva = new Cartuchera<Utiles>(7);
        private Lapiz lapiz1 = new Lapiz("Faber", 250, "Verde", "Grueso");
        private Goma goma1 = new Goma("Gomita", 300, "Rojo", 2);
        private Sacapunta sacapunta1 = new Sacapunta("Sacador", 700, "Lila", "Madera");

        private Cartuchera<Fibron> cartucheraFibrones = new Cartuchera<Fibron>(3);
        private Fibron fibron1 = new Fibron("Calabo", 100, "Verde", 5);
        private Fibron fibron2 = new Fibron("Tetra", 200, "Naranja", 10);
        private Fibron fibron3 = new Fibron("Fibra", 250, "Amarillo", 7);

        public delegate void DelegadoTinta(Fibron fibron, int tinta);
        public event DelegadoTinta SinTintaEvento;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            List<Lapiz> listaLapices = GestionDB.LeerLapices();
            List<Goma> listaGomas = GestionDB.LeerGomas();
            List<Sacapunta> listaSacapuntas = GestionDB.LeerSacapuntas();
            List<Fibron> listaFibron = GestionDB.LeerFibrones();

            foreach (Lapiz lapiz in listaLapices)
            {
                cartucheraNueva.ListaElementos.Add(lapiz);
            }
            foreach (Goma goma in listaGomas)
            {
                cartucheraNueva.ListaElementos.Add(goma);
            }
            foreach (Sacapunta sacapunta in listaSacapuntas)
            {
                cartucheraNueva.ListaElementos.Add(sacapunta);
            }
            foreach (Fibron fibron in listaFibron)
            {
                cartucheraNueva.ListaElementos.Add(fibron);
            }

            cartucheraFibrones.ListaElementos.Add(fibron1);
            cartucheraFibrones.ListaElementos.Add(fibron2);
            cartucheraFibrones.ListaElementos.Add(fibron3);
            SinTintaEvento += sinTintaError;

            tmrActualizarDGV.Start(); //Refresh DGV
        }

        private void btnAgregarUtil_Click(object sender, EventArgs e)
        {
            FrmMenuAgregar frmMenuAgregar = new FrmMenuAgregar(cartucheraNueva);
            this.Visible = false;
            frmMenuAgregar.ShowDialog();
            this.Visible = true;
        }

        private void btnleerTicket_Click(object sender, EventArgs e)
        {
            string path = "tickets.log";
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists($"{ruta}\\{path}"))
            {
                using(StreamReader sr = new StreamReader($"{ruta}\\{path}"))
                {
                    MessageBox.Show(sr.ReadToEnd(), "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe.", "ARCHIVO INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbdVerLapices.Checked)
                {
                    string marca = dgvUtiles.SelectedRows[0].Cells[1].Value.ToString();
                    int precio = Convert.ToInt32(dgvUtiles.SelectedRows[0].Cells[2].Value);
                    string color = dgvUtiles.SelectedRows[0].Cells[3].Value.ToString();
                    string trazo = dgvUtiles.SelectedRows[0].Cells[4].Value.ToString();

                    Lapiz lapiz = new Lapiz(marca, precio, color, trazo);

                    lapiz.SerializaXML();
                    MessageBox.Show("Se serializo correctamente el lapiz a XML.", "SERIALIZACION A XML REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se selecciono otro tipo de util. Seleccione un lapiz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException) 
            {
                MessageBox.Show("Se selecciono otro tipo de util. Seleccione un lapiz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeserelizarXML_Click(object sender, EventArgs e)
        {
            try
            {
                lapiz1 = (Lapiz)lapiz1.DeserializaXML();

                MessageBox.Show(lapiz1.ToString(), "LAPIZ DESERELIZADO DE XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se puede deserealizar porque todavia no se serializo ningun lapiz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSerializarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbdVerLapices.Checked)
                {
                    string marca = dgvUtiles.SelectedRows[0].Cells[1].Value.ToString();
                    int precio = Convert.ToInt32(dgvUtiles.SelectedRows[0].Cells[2].Value);
                    string color = dgvUtiles.SelectedRows[0].Cells[3].Value.ToString();
                    string trazo = dgvUtiles.SelectedRows[0].Cells[4].Value.ToString();

                    Lapiz lapiz = new Lapiz(marca, precio, color, trazo);

                    lapiz.SerializaJson();
                    MessageBox.Show("Se serializo correctamente el lapiz a JSON.", "SERIALIZACION A JSON REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se selecciono otro tipo de util. Seleccione un lapiz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Se selecciono otro tipo de util. Seleccione un lapiz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeserializarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                lapiz1 = (Lapiz)lapiz1.DeserializaJson();

                MessageBox.Show(lapiz1.ToString(), "LAPIZ DESERELIZADO DE JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se puede deserealizar porque todavia no se serializo ningun lapiz.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarUtil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUtiles.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("¿Estas seguro que quiere modificar este util?", "MODIFICAR UTIL", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (rbdVerLapices.Checked)
                    {
                        FrmModificar frmModificarLapiz = new FrmModificar(lapiz1, id);
                        this.Visible = false;
                        frmModificarLapiz.ShowDialog();
                        this.Visible = true;
                    }
                    else if (rbdVerGomas.Checked)
                    {
                        FrmModificar frmModificarGoma = new FrmModificar(goma1, id);
                        this.Visible = false;
                        frmModificarGoma.ShowDialog();
                        this.Visible = true;
                    }
                    else if (rbdVerSacapuntas.Checked)
                    {
                        FrmModificar frmModificarSacapunta = new FrmModificar(sacapunta1, id);
                        this.Visible = false;
                        frmModificarSacapunta.ShowDialog();
                        this.Visible = true;
                    }
                    else if (rbdVerFibrones.Checked)
                    {
                        FrmModificar frmModificarFibron = new FrmModificar(fibron1, id);
                        this.Visible = false;
                        frmModificarFibron.ShowDialog();
                        this.Visible = true;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un util para cambiar.", "NINGUN UTIL SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Seleccione un lapiz, goma o sacapunta para cambiar (NO FIBRON).", "MAL SELECCIONADO EL UTIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarUtil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUtiles.SelectedRows[0].Cells[0].Value);
                if (MessageBox.Show("¿Estas seguro que quiere eliminar este util?", "ELIMINAR UTIL", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (rbdVerLapices.Checked)
                    {
                        GestionDB.Eliminar(lapiz1, id);
                        dgvUtiles.DataSource = GestionDB.LeerLapices();
                    }
                    else if (rbdVerGomas.Checked)
                    {
                        GestionDB.Eliminar(goma1, id);
                        dgvUtiles.DataSource = GestionDB.LeerGomas();
                    }
                    else if (rbdVerSacapuntas.Checked)
                    {
                        GestionDB.Eliminar(sacapunta1, id);
                        dgvUtiles.DataSource = GestionDB.LeerSacapuntas();
                    }
                    else if (rbdVerFibrones.Checked)
                    {
                        GestionDB.Eliminar(fibron1, id);
                        dgvUtiles.DataSource = GestionDB.LeerFibrones();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un util para eliminar.", "NINGUN UTIL SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Seleccione un lapiz, goma o sacapunta para eliminar (NO FIBRON).", "MAL SELECCIONADO EL UTIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbdVerLapices_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUtiles.DataSource = null;
                dgvUtiles.DataSource = GestionDB.LeerLapices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbdVerGomas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUtiles.DataSource = null;
                dgvUtiles.DataSource = GestionDB.LeerGomas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbdVerSacapuntas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUtiles.DataSource = null;
                dgvUtiles.DataSource = GestionDB.LeerSacapuntas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbdVerFibrones_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvUtiles.DataSource = null;
                dgvUtiles.DataSource = GestionDB.LeerFibrones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResaltar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int elegido = random.Next(0, cartucheraFibrones.ListaElementos.Count);
            Fibron fibron = cartucheraFibrones.ListaElementos[elegido];
            int tintaResaltar = random.Next(1, 11);

            try
            {
                int cantidadTintaAux = fibron.CantidadTinta;
                fibron.Resaltar(tintaResaltar);
                MessageBox.Show($"La tinta del fibron alcanzo para resaltar.\n" +
                    $"Tinta del fibron: {cantidadTintaAux}\n" +
                    $"Tinta a resaltar: {tintaResaltar}", "RESALTADO CON EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SinTintaException)
            {
                SinTintaEvento(fibron, tintaResaltar);
                MessageBox.Show($"La tinta del fibron NO alcanzo para resaltar.\n" +
                    $"Tinta del fibron: {fibron.CantidadTinta}\n" +
                    $"Tinta a resaltar: {tintaResaltar}", "RESALTADO FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void sinTintaError(Fibron fibron, int tintaResaltar)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string evento = string.Empty;

            using (StreamWriter sw = new StreamWriter($"{ruta}\\errors.log"))
            {
                sw.WriteLine(fibron.ToString());
                sw.WriteLine($"Tinta a escribir: {tintaResaltar}");
                sw.WriteLine($"Le falto: {tintaResaltar - fibron.CantidadTinta} de tinta.");
            }

            MessageBox.Show(evento.EscuchandoEvento(), "ESCUCHANDO EL EVENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrActualizarDGV_Tick(object sender, EventArgs e)
        {
            //dgvUtiles.Refresh();
            //dgvUtiles.Update();
            if(rbdVerLapices.Checked)
            {
                dgvUtiles.DataSource = null;
                dgvUtiles.DataSource = GestionDB.LeerLapices();
            }
            else if(rbdVerGomas.Checked)
            {
                dgvUtiles.DataSource = null;
                dgvUtiles.DataSource = GestionDB.LeerGomas();
            }
            else if(rbdVerSacapuntas.Checked) 
            {
                dgvUtiles.DataSource = null;
                dgvUtiles.DataSource = GestionDB.LeerSacapuntas();
            }
            else if(rbdVerFibrones.Checked) 
            {
                dgvUtiles.DataSource = null;
                dgvUtiles.DataSource = GestionDB.LeerFibrones();
            }

            tmrActualizarDGV.Start();
        }

        private void btnSerializarFibronXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbdVerFibrones.Checked)
                {
                    string marca = dgvUtiles.SelectedRows[0].Cells[0].Value.ToString();
                    int precio = Convert.ToInt32(dgvUtiles.SelectedRows[0].Cells[1].Value);
                    string color = dgvUtiles.SelectedRows[0].Cells[2].Value.ToString();
                    int cantidadTinta = Convert.ToInt32(dgvUtiles.SelectedRows[0].Cells[3].Value);

                    Fibron fibron = new Fibron(marca, precio, color, cantidadTinta);

                    fibron.SerializaXML();
                    MessageBox.Show("Se serializo correctamente el fibron a XML.", "SERIALIZACION A XML REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se selecciono otro tipo de util. Seleccione un fibron.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Se selecciono otro tipo de util. Seleccione un fibron.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeserializarFibronXML_Click(object sender, EventArgs e)
        {
            try
            {
                fibron1 = (Fibron)fibron1.DeserializaXML();

                MessageBox.Show(fibron1.ToString(), "FIBRON DESERELIZADO DE XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se puede deserealizar porque todavia no se serializo ningun fibron.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSerializarFibronJSON_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbdVerFibrones.Checked)
                {
                    string marca = dgvUtiles.SelectedRows[0].Cells[0].Value.ToString();
                    int precio = Convert.ToInt32(dgvUtiles.SelectedRows[0].Cells[1].Value);
                    string color = dgvUtiles.SelectedRows[0].Cells[2].Value.ToString();
                    int cantidadTinta = Convert.ToInt32(dgvUtiles.SelectedRows[0].Cells[3].Value);

                    Fibron fibron = new Fibron(marca, precio, color, cantidadTinta);


                    fibron.SerializaJson();
                    MessageBox.Show("Se serializo correctamente el fibron a JSON.", "SERIALIZACION A JSON REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se selecciono otro tipo de util. Seleccione un fibron.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Se selecciono otro tipo de util. Seleccione un fibron.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeserializarFibronJSON_Click(object sender, EventArgs e)
        {
            try
            {
                fibron1 = (Fibron)fibron1.DeserializaJson();

                MessageBox.Show(fibron1.ToString(), "FIBRON DESERELIZADO DE JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No se puede deserealizar porque todavia no se serializo ningun fibron.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LeerNombres(Cartuchera<Utiles> cartcuhera)
        {
            int contadorCaracteres = 0;

            foreach (Utiles util in cartcuhera.ListaElementos)
            {
                contadorCaracteres += util.Marca.ContarCaracteres();
            }
        }
    }
}
