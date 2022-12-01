namespace TP2_Labo
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvUtiles = new System.Windows.Forms.DataGridView();
            this.btnDeserializarJSON = new System.Windows.Forms.Button();
            this.btnSerializarJSON = new System.Windows.Forms.Button();
            this.btnDeserelizarXML = new System.Windows.Forms.Button();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.btnleerTicket = new System.Windows.Forms.Button();
            this.btnAgregarUtil = new System.Windows.Forms.Button();
            this.rbdVerLapices = new System.Windows.Forms.RadioButton();
            this.rbdVerGomas = new System.Windows.Forms.RadioButton();
            this.rbdVerSacapuntas = new System.Windows.Forms.RadioButton();
            this.rbdVerFibrones = new System.Windows.Forms.RadioButton();
            this.gbxVer = new System.Windows.Forms.GroupBox();
            this.btnModificarUtil = new System.Windows.Forms.Button();
            this.btnEliminarUtil = new System.Windows.Forms.Button();
            this.btnResaltar = new System.Windows.Forms.Button();
            this.tmrActualizarDGV = new System.Windows.Forms.Timer(this.components);
            this.btnDeserializarFibronJSON = new System.Windows.Forms.Button();
            this.btnSerializarFibronJSON = new System.Windows.Forms.Button();
            this.btnDeserializarFibronXML = new System.Windows.Forms.Button();
            this.btnSerializarFibronXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtiles)).BeginInit();
            this.gbxVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUtiles
            // 
            this.dgvUtiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtiles.Location = new System.Drawing.Point(222, 46);
            this.dgvUtiles.MultiSelect = false;
            this.dgvUtiles.Name = "dgvUtiles";
            this.dgvUtiles.ReadOnly = true;
            this.dgvUtiles.RowTemplate.Height = 25;
            this.dgvUtiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtiles.Size = new System.Drawing.Size(563, 240);
            this.dgvUtiles.TabIndex = 20;
            // 
            // btnDeserializarJSON
            // 
            this.btnDeserializarJSON.Location = new System.Drawing.Point(650, 308);
            this.btnDeserializarJSON.Name = "btnDeserializarJSON";
            this.btnDeserializarJSON.Size = new System.Drawing.Size(106, 46);
            this.btnDeserializarJSON.TabIndex = 19;
            this.btnDeserializarJSON.Text = "Deserializar Lapiz JSON";
            this.btnDeserializarJSON.UseVisualStyleBackColor = true;
            this.btnDeserializarJSON.Click += new System.EventHandler(this.btnDeserializarJSON_Click);
            // 
            // btnSerializarJSON
            // 
            this.btnSerializarJSON.Location = new System.Drawing.Point(538, 308);
            this.btnSerializarJSON.Name = "btnSerializarJSON";
            this.btnSerializarJSON.Size = new System.Drawing.Size(106, 46);
            this.btnSerializarJSON.TabIndex = 18;
            this.btnSerializarJSON.Text = "Serializar Lapiz JSON";
            this.btnSerializarJSON.UseVisualStyleBackColor = true;
            this.btnSerializarJSON.Click += new System.EventHandler(this.btnSerializarJSON_Click);
            // 
            // btnDeserelizarXML
            // 
            this.btnDeserelizarXML.Location = new System.Drawing.Point(377, 308);
            this.btnDeserelizarXML.Name = "btnDeserelizarXML";
            this.btnDeserelizarXML.Size = new System.Drawing.Size(106, 46);
            this.btnDeserelizarXML.TabIndex = 17;
            this.btnDeserelizarXML.Text = "Deserializar Lapiz XML";
            this.btnDeserelizarXML.UseVisualStyleBackColor = true;
            this.btnDeserelizarXML.Click += new System.EventHandler(this.btnDeserelizarXML_Click);
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.Location = new System.Drawing.Point(265, 308);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(106, 46);
            this.btnSerializarXML.TabIndex = 16;
            this.btnSerializarXML.Text = "Serializar Lapiz XML";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // btnleerTicket
            // 
            this.btnleerTicket.Location = new System.Drawing.Point(49, 308);
            this.btnleerTicket.Name = "btnleerTicket";
            this.btnleerTicket.Size = new System.Drawing.Size(115, 50);
            this.btnleerTicket.TabIndex = 14;
            this.btnleerTicket.Text = "Leer Ticket";
            this.btnleerTicket.UseVisualStyleBackColor = true;
            this.btnleerTicket.Click += new System.EventHandler(this.btnleerTicket_Click);
            // 
            // btnAgregarUtil
            // 
            this.btnAgregarUtil.Location = new System.Drawing.Point(818, 76);
            this.btnAgregarUtil.Name = "btnAgregarUtil";
            this.btnAgregarUtil.Size = new System.Drawing.Size(115, 50);
            this.btnAgregarUtil.TabIndex = 11;
            this.btnAgregarUtil.Text = "Agregar Util";
            this.btnAgregarUtil.UseVisualStyleBackColor = true;
            this.btnAgregarUtil.Click += new System.EventHandler(this.btnAgregarUtil_Click);
            // 
            // rbdVerLapices
            // 
            this.rbdVerLapices.AutoSize = true;
            this.rbdVerLapices.Location = new System.Drawing.Point(27, 35);
            this.rbdVerLapices.Name = "rbdVerLapices";
            this.rbdVerLapices.Size = new System.Drawing.Size(83, 19);
            this.rbdVerLapices.TabIndex = 21;
            this.rbdVerLapices.TabStop = true;
            this.rbdVerLapices.Text = "Ver Lapices";
            this.rbdVerLapices.UseVisualStyleBackColor = true;
            this.rbdVerLapices.CheckedChanged += new System.EventHandler(this.rbdVerLapices_CheckedChanged);
            // 
            // rbdVerGomas
            // 
            this.rbdVerGomas.AutoSize = true;
            this.rbdVerGomas.Location = new System.Drawing.Point(27, 60);
            this.rbdVerGomas.Name = "rbdVerGomas";
            this.rbdVerGomas.Size = new System.Drawing.Size(81, 19);
            this.rbdVerGomas.TabIndex = 22;
            this.rbdVerGomas.TabStop = true;
            this.rbdVerGomas.Text = "Ver Gomas";
            this.rbdVerGomas.UseVisualStyleBackColor = true;
            this.rbdVerGomas.CheckedChanged += new System.EventHandler(this.rbdVerGomas_CheckedChanged);
            // 
            // rbdVerSacapuntas
            // 
            this.rbdVerSacapuntas.AutoSize = true;
            this.rbdVerSacapuntas.Location = new System.Drawing.Point(27, 85);
            this.rbdVerSacapuntas.Name = "rbdVerSacapuntas";
            this.rbdVerSacapuntas.Size = new System.Drawing.Size(104, 19);
            this.rbdVerSacapuntas.TabIndex = 24;
            this.rbdVerSacapuntas.TabStop = true;
            this.rbdVerSacapuntas.Text = "Ver Sacapuntas";
            this.rbdVerSacapuntas.UseVisualStyleBackColor = true;
            this.rbdVerSacapuntas.CheckedChanged += new System.EventHandler(this.rbdVerSacapuntas_CheckedChanged);
            // 
            // rbdVerFibrones
            // 
            this.rbdVerFibrones.AutoSize = true;
            this.rbdVerFibrones.Location = new System.Drawing.Point(27, 110);
            this.rbdVerFibrones.Name = "rbdVerFibrones";
            this.rbdVerFibrones.Size = new System.Drawing.Size(89, 19);
            this.rbdVerFibrones.TabIndex = 23;
            this.rbdVerFibrones.TabStop = true;
            this.rbdVerFibrones.Text = "Ver Fibrones";
            this.rbdVerFibrones.UseVisualStyleBackColor = true;
            this.rbdVerFibrones.CheckedChanged += new System.EventHandler(this.rbdVerFibrones_CheckedChanged);
            // 
            // gbxVer
            // 
            this.gbxVer.Controls.Add(this.rbdVerSacapuntas);
            this.gbxVer.Controls.Add(this.rbdVerLapices);
            this.gbxVer.Controls.Add(this.rbdVerFibrones);
            this.gbxVer.Controls.Add(this.rbdVerGomas);
            this.gbxVer.Location = new System.Drawing.Point(33, 46);
            this.gbxVer.Name = "gbxVer";
            this.gbxVer.Size = new System.Drawing.Size(152, 162);
            this.gbxVer.TabIndex = 25;
            this.gbxVer.TabStop = false;
            // 
            // btnModificarUtil
            // 
            this.btnModificarUtil.Location = new System.Drawing.Point(818, 147);
            this.btnModificarUtil.Name = "btnModificarUtil";
            this.btnModificarUtil.Size = new System.Drawing.Size(115, 50);
            this.btnModificarUtil.TabIndex = 26;
            this.btnModificarUtil.Text = "Modificar Util";
            this.btnModificarUtil.UseVisualStyleBackColor = true;
            this.btnModificarUtil.Click += new System.EventHandler(this.btnModificarUtil_Click);
            // 
            // btnEliminarUtil
            // 
            this.btnEliminarUtil.Location = new System.Drawing.Point(818, 221);
            this.btnEliminarUtil.Name = "btnEliminarUtil";
            this.btnEliminarUtil.Size = new System.Drawing.Size(115, 50);
            this.btnEliminarUtil.TabIndex = 27;
            this.btnEliminarUtil.Text = "Eliminar Util";
            this.btnEliminarUtil.UseVisualStyleBackColor = true;
            this.btnEliminarUtil.Click += new System.EventHandler(this.btnEliminarUtil_Click);
            // 
            // btnResaltar
            // 
            this.btnResaltar.Location = new System.Drawing.Point(49, 236);
            this.btnResaltar.Name = "btnResaltar";
            this.btnResaltar.Size = new System.Drawing.Size(115, 50);
            this.btnResaltar.TabIndex = 28;
            this.btnResaltar.Text = "Resaltar";
            this.btnResaltar.UseVisualStyleBackColor = true;
            this.btnResaltar.Click += new System.EventHandler(this.btnResaltar_Click);
            // 
            // tmrActualizarDGV
            // 
            this.tmrActualizarDGV.Enabled = true;
            this.tmrActualizarDGV.Interval = 4000;
            this.tmrActualizarDGV.Tick += new System.EventHandler(this.tmrActualizarDGV_Tick);
            // 
            // btnDeserializarFibronJSON
            // 
            this.btnDeserializarFibronJSON.Location = new System.Drawing.Point(650, 374);
            this.btnDeserializarFibronJSON.Name = "btnDeserializarFibronJSON";
            this.btnDeserializarFibronJSON.Size = new System.Drawing.Size(106, 46);
            this.btnDeserializarFibronJSON.TabIndex = 32;
            this.btnDeserializarFibronJSON.Text = "Deserializar Fibron JSON";
            this.btnDeserializarFibronJSON.UseVisualStyleBackColor = true;
            this.btnDeserializarFibronJSON.Click += new System.EventHandler(this.btnDeserializarFibronJSON_Click);
            // 
            // btnSerializarFibronJSON
            // 
            this.btnSerializarFibronJSON.Location = new System.Drawing.Point(538, 374);
            this.btnSerializarFibronJSON.Name = "btnSerializarFibronJSON";
            this.btnSerializarFibronJSON.Size = new System.Drawing.Size(106, 46);
            this.btnSerializarFibronJSON.TabIndex = 31;
            this.btnSerializarFibronJSON.Text = "Serializar Fibron JSON";
            this.btnSerializarFibronJSON.UseVisualStyleBackColor = true;
            this.btnSerializarFibronJSON.Click += new System.EventHandler(this.btnSerializarFibronJSON_Click);
            // 
            // btnDeserializarFibronXML
            // 
            this.btnDeserializarFibronXML.Location = new System.Drawing.Point(377, 374);
            this.btnDeserializarFibronXML.Name = "btnDeserializarFibronXML";
            this.btnDeserializarFibronXML.Size = new System.Drawing.Size(106, 46);
            this.btnDeserializarFibronXML.TabIndex = 30;
            this.btnDeserializarFibronXML.Text = "Deserializar Fibron XML";
            this.btnDeserializarFibronXML.UseVisualStyleBackColor = true;
            this.btnDeserializarFibronXML.Click += new System.EventHandler(this.btnDeserializarFibronXML_Click);
            // 
            // btnSerializarFibronXML
            // 
            this.btnSerializarFibronXML.Location = new System.Drawing.Point(265, 374);
            this.btnSerializarFibronXML.Name = "btnSerializarFibronXML";
            this.btnSerializarFibronXML.Size = new System.Drawing.Size(106, 46);
            this.btnSerializarFibronXML.TabIndex = 29;
            this.btnSerializarFibronXML.Text = "Serializar Fibron XML";
            this.btnSerializarFibronXML.UseVisualStyleBackColor = true;
            this.btnSerializarFibronXML.Click += new System.EventHandler(this.btnSerializarFibronXML_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 446);
            this.Controls.Add(this.btnDeserializarFibronJSON);
            this.Controls.Add(this.btnSerializarFibronJSON);
            this.Controls.Add(this.btnDeserializarFibronXML);
            this.Controls.Add(this.btnSerializarFibronXML);
            this.Controls.Add(this.btnResaltar);
            this.Controls.Add(this.btnEliminarUtil);
            this.Controls.Add(this.btnModificarUtil);
            this.Controls.Add(this.gbxVer);
            this.Controls.Add(this.dgvUtiles);
            this.Controls.Add(this.btnDeserializarJSON);
            this.Controls.Add(this.btnSerializarJSON);
            this.Controls.Add(this.btnDeserelizarXML);
            this.Controls.Add(this.btnSerializarXML);
            this.Controls.Add(this.btnleerTicket);
            this.Controls.Add(this.btnAgregarUtil);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtiles)).EndInit();
            this.gbxVer.ResumeLayout(false);
            this.gbxVer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUtiles;
        private Button btnDeserializarJSON;
        private Button btnSerializarJSON;
        private Button btnDeserelizarXML;
        private Button btnSerializarXML;
        private Button btnleerTicket;
        private Button btnAgregarUtil;
        private RadioButton rbdVerLapices;
        private RadioButton rbdVerGomas;
        private RadioButton rbdVerSacapuntas;
        private RadioButton rbdVerFibrones;
        private GroupBox gbxVer;
        private Button btnModificarUtil;
        private Button btnEliminarUtil;
        private Button btnResaltar;
        private System.Windows.Forms.Timer tmrActualizarDGV;
        private Button btnDeserializarFibronJSON;
        private Button btnSerializarFibronJSON;
        private Button btnDeserializarFibronXML;
        private Button btnSerializarFibronXML;
    }
}