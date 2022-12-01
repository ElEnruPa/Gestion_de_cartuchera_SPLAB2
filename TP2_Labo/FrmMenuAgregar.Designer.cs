namespace Formularios
{
    partial class FrmMenuAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarLapiz = new System.Windows.Forms.Button();
            this.btnAgregarGoma = new System.Windows.Forms.Button();
            this.btnAgregarSacapunta = new System.Windows.Forms.Button();
            this.lblCapacidadActual = new System.Windows.Forms.Label();
            this.lblNuevaCapacidad = new System.Windows.Forms.Label();
            this.nupdCapacidad = new System.Windows.Forms.NumericUpDown();
            this.btnCambiarCapacidad = new System.Windows.Forms.Button();
            this.txtMarcaLapiz = new System.Windows.Forms.TextBox();
            this.nupdPrecioLapiz = new System.Windows.Forms.NumericUpDown();
            this.lblMarcaLapiz = new System.Windows.Forms.Label();
            this.lblPrecioLapiz = new System.Windows.Forms.Label();
            this.lblColorLapiz = new System.Windows.Forms.Label();
            this.txtColorLapiz = new System.Windows.Forms.TextBox();
            this.lblPrecioGoma = new System.Windows.Forms.Label();
            this.lblMarcaGoma = new System.Windows.Forms.Label();
            this.nupdPrecioGoma = new System.Windows.Forms.NumericUpDown();
            this.txtMarcaGoma = new System.Windows.Forms.TextBox();
            this.lblPrecioSacapunta = new System.Windows.Forms.Label();
            this.lblMarcaSacapunta = new System.Windows.Forms.Label();
            this.nupdPrecioSacapunta = new System.Windows.Forms.NumericUpDown();
            this.txtMarcaSacapunta = new System.Windows.Forms.TextBox();
            this.lblTamanioGoma = new System.Windows.Forms.Label();
            this.nupdTamanioGoma = new System.Windows.Forms.NumericUpDown();
            this.lblColorGoma = new System.Windows.Forms.Label();
            this.txtColorGoma = new System.Windows.Forms.TextBox();
            this.lblColorSacapunta = new System.Windows.Forms.Label();
            this.txtColorSacapunta = new System.Windows.Forms.TextBox();
            this.lblMaterialSacapunta = new System.Windows.Forms.Label();
            this.lblTrazoLapiz = new System.Windows.Forms.Label();
            this.gbxLapiz = new System.Windows.Forms.GroupBox();
            this.cbxTrazoLapiz = new System.Windows.Forms.ComboBox();
            this.cbxMateriaSacapunta = new System.Windows.Forms.ComboBox();
            this.gbxGoma = new System.Windows.Forms.GroupBox();
            this.gbxSacapunta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupdCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPrecioLapiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPrecioGoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPrecioSacapunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdTamanioGoma)).BeginInit();
            this.gbxLapiz.SuspendLayout();
            this.gbxGoma.SuspendLayout();
            this.gbxSacapunta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarLapiz
            // 
            this.btnAgregarLapiz.Location = new System.Drawing.Point(6, 306);
            this.btnAgregarLapiz.Name = "btnAgregarLapiz";
            this.btnAgregarLapiz.Size = new System.Drawing.Size(100, 50);
            this.btnAgregarLapiz.TabIndex = 0;
            this.btnAgregarLapiz.Text = "Agregar Lapiz";
            this.btnAgregarLapiz.UseVisualStyleBackColor = true;
            this.btnAgregarLapiz.Click += new System.EventHandler(this.btnAgregarLapiz_Click);
            // 
            // btnAgregarGoma
            // 
            this.btnAgregarGoma.Location = new System.Drawing.Point(6, 306);
            this.btnAgregarGoma.Name = "btnAgregarGoma";
            this.btnAgregarGoma.Size = new System.Drawing.Size(100, 50);
            this.btnAgregarGoma.TabIndex = 1;
            this.btnAgregarGoma.Text = "Agregar Goma";
            this.btnAgregarGoma.UseVisualStyleBackColor = true;
            this.btnAgregarGoma.Click += new System.EventHandler(this.btnAgregarGoma_Click);
            // 
            // btnAgregarSacapunta
            // 
            this.btnAgregarSacapunta.Location = new System.Drawing.Point(6, 306);
            this.btnAgregarSacapunta.Name = "btnAgregarSacapunta";
            this.btnAgregarSacapunta.Size = new System.Drawing.Size(100, 50);
            this.btnAgregarSacapunta.TabIndex = 2;
            this.btnAgregarSacapunta.Text = "Agregar Sacapunta";
            this.btnAgregarSacapunta.UseVisualStyleBackColor = true;
            this.btnAgregarSacapunta.Click += new System.EventHandler(this.btnAgregarSacapunta_Click);
            // 
            // lblCapacidadActual
            // 
            this.lblCapacidadActual.AutoSize = true;
            this.lblCapacidadActual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapacidadActual.Location = new System.Drawing.Point(273, 468);
            this.lblCapacidadActual.Name = "lblCapacidadActual";
            this.lblCapacidadActual.Size = new System.Drawing.Size(276, 20);
            this.lblCapacidadActual.TabIndex = 3;
            this.lblCapacidadActual.Text = "La capacidad actual de la cartuchera es: ";
            // 
            // lblNuevaCapacidad
            // 
            this.lblNuevaCapacidad.AutoSize = true;
            this.lblNuevaCapacidad.Location = new System.Drawing.Point(269, 511);
            this.lblNuevaCapacidad.Name = "lblNuevaCapacidad";
            this.lblNuevaCapacidad.Size = new System.Drawing.Size(101, 15);
            this.lblNuevaCapacidad.TabIndex = 4;
            this.lblNuevaCapacidad.Text = "Nueva capacidad:";
            // 
            // nupdCapacidad
            // 
            this.nupdCapacidad.Location = new System.Drawing.Point(269, 529);
            this.nupdCapacidad.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nupdCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdCapacidad.Name = "nupdCapacidad";
            this.nupdCapacidad.Size = new System.Drawing.Size(116, 23);
            this.nupdCapacidad.TabIndex = 5;
            this.nupdCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCambiarCapacidad
            // 
            this.btnCambiarCapacidad.Location = new System.Drawing.Point(465, 513);
            this.btnCambiarCapacidad.Name = "btnCambiarCapacidad";
            this.btnCambiarCapacidad.Size = new System.Drawing.Size(100, 50);
            this.btnCambiarCapacidad.TabIndex = 6;
            this.btnCambiarCapacidad.Text = "Cambiar Capacidad";
            this.btnCambiarCapacidad.UseVisualStyleBackColor = true;
            this.btnCambiarCapacidad.Click += new System.EventHandler(this.btnCambiarCapacidad_Click);
            // 
            // txtMarcaLapiz
            // 
            this.txtMarcaLapiz.Location = new System.Drawing.Point(6, 54);
            this.txtMarcaLapiz.Name = "txtMarcaLapiz";
            this.txtMarcaLapiz.Size = new System.Drawing.Size(120, 23);
            this.txtMarcaLapiz.TabIndex = 7;
            // 
            // nupdPrecioLapiz
            // 
            this.nupdPrecioLapiz.Location = new System.Drawing.Point(6, 117);
            this.nupdPrecioLapiz.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupdPrecioLapiz.Name = "nupdPrecioLapiz";
            this.nupdPrecioLapiz.Size = new System.Drawing.Size(120, 23);
            this.nupdPrecioLapiz.TabIndex = 8;
            // 
            // lblMarcaLapiz
            // 
            this.lblMarcaLapiz.AutoSize = true;
            this.lblMarcaLapiz.Location = new System.Drawing.Point(6, 36);
            this.lblMarcaLapiz.Name = "lblMarcaLapiz";
            this.lblMarcaLapiz.Size = new System.Drawing.Size(43, 15);
            this.lblMarcaLapiz.TabIndex = 10;
            this.lblMarcaLapiz.Text = "Marca:";
            // 
            // lblPrecioLapiz
            // 
            this.lblPrecioLapiz.AutoSize = true;
            this.lblPrecioLapiz.Location = new System.Drawing.Point(6, 99);
            this.lblPrecioLapiz.Name = "lblPrecioLapiz";
            this.lblPrecioLapiz.Size = new System.Drawing.Size(43, 15);
            this.lblPrecioLapiz.TabIndex = 11;
            this.lblPrecioLapiz.Text = "Precio:";
            // 
            // lblColorLapiz
            // 
            this.lblColorLapiz.AutoSize = true;
            this.lblColorLapiz.Location = new System.Drawing.Point(6, 160);
            this.lblColorLapiz.Name = "lblColorLapiz";
            this.lblColorLapiz.Size = new System.Drawing.Size(39, 15);
            this.lblColorLapiz.TabIndex = 13;
            this.lblColorLapiz.Text = "Color:";
            // 
            // txtColorLapiz
            // 
            this.txtColorLapiz.Location = new System.Drawing.Point(6, 178);
            this.txtColorLapiz.Name = "txtColorLapiz";
            this.txtColorLapiz.Size = new System.Drawing.Size(120, 23);
            this.txtColorLapiz.TabIndex = 12;
            // 
            // lblPrecioGoma
            // 
            this.lblPrecioGoma.AutoSize = true;
            this.lblPrecioGoma.Location = new System.Drawing.Point(6, 99);
            this.lblPrecioGoma.Name = "lblPrecioGoma";
            this.lblPrecioGoma.Size = new System.Drawing.Size(43, 15);
            this.lblPrecioGoma.TabIndex = 19;
            this.lblPrecioGoma.Text = "Precio:";
            // 
            // lblMarcaGoma
            // 
            this.lblMarcaGoma.AutoSize = true;
            this.lblMarcaGoma.Location = new System.Drawing.Point(6, 36);
            this.lblMarcaGoma.Name = "lblMarcaGoma";
            this.lblMarcaGoma.Size = new System.Drawing.Size(43, 15);
            this.lblMarcaGoma.TabIndex = 18;
            this.lblMarcaGoma.Text = "Marca:";
            // 
            // nupdPrecioGoma
            // 
            this.nupdPrecioGoma.Location = new System.Drawing.Point(6, 117);
            this.nupdPrecioGoma.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupdPrecioGoma.Name = "nupdPrecioGoma";
            this.nupdPrecioGoma.Size = new System.Drawing.Size(120, 23);
            this.nupdPrecioGoma.TabIndex = 17;
            // 
            // txtMarcaGoma
            // 
            this.txtMarcaGoma.Location = new System.Drawing.Point(6, 54);
            this.txtMarcaGoma.Name = "txtMarcaGoma";
            this.txtMarcaGoma.Size = new System.Drawing.Size(120, 23);
            this.txtMarcaGoma.TabIndex = 16;
            // 
            // lblPrecioSacapunta
            // 
            this.lblPrecioSacapunta.AutoSize = true;
            this.lblPrecioSacapunta.Location = new System.Drawing.Point(6, 99);
            this.lblPrecioSacapunta.Name = "lblPrecioSacapunta";
            this.lblPrecioSacapunta.Size = new System.Drawing.Size(43, 15);
            this.lblPrecioSacapunta.TabIndex = 23;
            this.lblPrecioSacapunta.Text = "Precio:";
            // 
            // lblMarcaSacapunta
            // 
            this.lblMarcaSacapunta.AutoSize = true;
            this.lblMarcaSacapunta.Location = new System.Drawing.Point(6, 36);
            this.lblMarcaSacapunta.Name = "lblMarcaSacapunta";
            this.lblMarcaSacapunta.Size = new System.Drawing.Size(43, 15);
            this.lblMarcaSacapunta.TabIndex = 22;
            this.lblMarcaSacapunta.Text = "Marca:";
            // 
            // nupdPrecioSacapunta
            // 
            this.nupdPrecioSacapunta.Location = new System.Drawing.Point(6, 117);
            this.nupdPrecioSacapunta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupdPrecioSacapunta.Name = "nupdPrecioSacapunta";
            this.nupdPrecioSacapunta.Size = new System.Drawing.Size(120, 23);
            this.nupdPrecioSacapunta.TabIndex = 21;
            // 
            // txtMarcaSacapunta
            // 
            this.txtMarcaSacapunta.Location = new System.Drawing.Point(6, 54);
            this.txtMarcaSacapunta.Name = "txtMarcaSacapunta";
            this.txtMarcaSacapunta.Size = new System.Drawing.Size(120, 23);
            this.txtMarcaSacapunta.TabIndex = 20;
            // 
            // lblTamanioGoma
            // 
            this.lblTamanioGoma.AutoSize = true;
            this.lblTamanioGoma.Location = new System.Drawing.Point(6, 223);
            this.lblTamanioGoma.Name = "lblTamanioGoma";
            this.lblTamanioGoma.Size = new System.Drawing.Size(52, 15);
            this.lblTamanioGoma.TabIndex = 27;
            this.lblTamanioGoma.Text = "Tamaño:";
            // 
            // nupdTamanioGoma
            // 
            this.nupdTamanioGoma.Location = new System.Drawing.Point(6, 241);
            this.nupdTamanioGoma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdTamanioGoma.Name = "nupdTamanioGoma";
            this.nupdTamanioGoma.Size = new System.Drawing.Size(120, 23);
            this.nupdTamanioGoma.TabIndex = 26;
            this.nupdTamanioGoma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblColorGoma
            // 
            this.lblColorGoma.AutoSize = true;
            this.lblColorGoma.Location = new System.Drawing.Point(6, 160);
            this.lblColorGoma.Name = "lblColorGoma";
            this.lblColorGoma.Size = new System.Drawing.Size(39, 15);
            this.lblColorGoma.TabIndex = 25;
            this.lblColorGoma.Text = "Color:";
            // 
            // txtColorGoma
            // 
            this.txtColorGoma.Location = new System.Drawing.Point(6, 178);
            this.txtColorGoma.Name = "txtColorGoma";
            this.txtColorGoma.Size = new System.Drawing.Size(120, 23);
            this.txtColorGoma.TabIndex = 24;
            // 
            // lblColorSacapunta
            // 
            this.lblColorSacapunta.AutoSize = true;
            this.lblColorSacapunta.Location = new System.Drawing.Point(6, 160);
            this.lblColorSacapunta.Name = "lblColorSacapunta";
            this.lblColorSacapunta.Size = new System.Drawing.Size(39, 15);
            this.lblColorSacapunta.TabIndex = 29;
            this.lblColorSacapunta.Text = "Color:";
            // 
            // txtColorSacapunta
            // 
            this.txtColorSacapunta.Location = new System.Drawing.Point(6, 178);
            this.txtColorSacapunta.Name = "txtColorSacapunta";
            this.txtColorSacapunta.Size = new System.Drawing.Size(120, 23);
            this.txtColorSacapunta.TabIndex = 28;
            // 
            // lblMaterialSacapunta
            // 
            this.lblMaterialSacapunta.AutoSize = true;
            this.lblMaterialSacapunta.Location = new System.Drawing.Point(6, 222);
            this.lblMaterialSacapunta.Name = "lblMaterialSacapunta";
            this.lblMaterialSacapunta.Size = new System.Drawing.Size(53, 15);
            this.lblMaterialSacapunta.TabIndex = 31;
            this.lblMaterialSacapunta.Text = "Material:";
            // 
            // lblTrazoLapiz
            // 
            this.lblTrazoLapiz.AutoSize = true;
            this.lblTrazoLapiz.Location = new System.Drawing.Point(6, 223);
            this.lblTrazoLapiz.Name = "lblTrazoLapiz";
            this.lblTrazoLapiz.Size = new System.Drawing.Size(37, 15);
            this.lblTrazoLapiz.TabIndex = 33;
            this.lblTrazoLapiz.Text = "Trazo:";
            // 
            // gbxLapiz
            // 
            this.gbxLapiz.Controls.Add(this.cbxTrazoLapiz);
            this.gbxLapiz.Controls.Add(this.btnAgregarLapiz);
            this.gbxLapiz.Controls.Add(this.lblTrazoLapiz);
            this.gbxLapiz.Controls.Add(this.txtMarcaLapiz);
            this.gbxLapiz.Controls.Add(this.nupdPrecioLapiz);
            this.gbxLapiz.Controls.Add(this.lblMarcaLapiz);
            this.gbxLapiz.Controls.Add(this.lblPrecioLapiz);
            this.gbxLapiz.Controls.Add(this.txtColorLapiz);
            this.gbxLapiz.Controls.Add(this.lblColorLapiz);
            this.gbxLapiz.Location = new System.Drawing.Point(85, 36);
            this.gbxLapiz.Name = "gbxLapiz";
            this.gbxLapiz.Size = new System.Drawing.Size(180, 383);
            this.gbxLapiz.TabIndex = 34;
            this.gbxLapiz.TabStop = false;
            this.gbxLapiz.Text = "Lapiz";
            // 
            // cbxTrazoLapiz
            // 
            this.cbxTrazoLapiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrazoLapiz.FormattingEnabled = true;
            this.cbxTrazoLapiz.Items.AddRange(new object[] {
            "Fino",
            "Medio",
            "Grueso"});
            this.cbxTrazoLapiz.Location = new System.Drawing.Point(5, 241);
            this.cbxTrazoLapiz.Name = "cbxTrazoLapiz";
            this.cbxTrazoLapiz.Size = new System.Drawing.Size(121, 23);
            this.cbxTrazoLapiz.TabIndex = 35;
            // 
            // cbxMateriaSacapunta
            // 
            this.cbxMateriaSacapunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMateriaSacapunta.FormattingEnabled = true;
            this.cbxMateriaSacapunta.Items.AddRange(new object[] {
            "Plastico",
            "Metal",
            "Madera"});
            this.cbxMateriaSacapunta.Location = new System.Drawing.Point(5, 241);
            this.cbxMateriaSacapunta.Name = "cbxMateriaSacapunta";
            this.cbxMateriaSacapunta.Size = new System.Drawing.Size(121, 23);
            this.cbxMateriaSacapunta.TabIndex = 36;
            // 
            // gbxGoma
            // 
            this.gbxGoma.Controls.Add(this.lblMarcaGoma);
            this.gbxGoma.Controls.Add(this.btnAgregarGoma);
            this.gbxGoma.Controls.Add(this.txtMarcaGoma);
            this.gbxGoma.Controls.Add(this.nupdPrecioGoma);
            this.gbxGoma.Controls.Add(this.lblPrecioGoma);
            this.gbxGoma.Controls.Add(this.txtColorGoma);
            this.gbxGoma.Controls.Add(this.lblTamanioGoma);
            this.gbxGoma.Controls.Add(this.lblColorGoma);
            this.gbxGoma.Controls.Add(this.nupdTamanioGoma);
            this.gbxGoma.Location = new System.Drawing.Point(330, 36);
            this.gbxGoma.Name = "gbxGoma";
            this.gbxGoma.Size = new System.Drawing.Size(180, 383);
            this.gbxGoma.TabIndex = 37;
            this.gbxGoma.TabStop = false;
            this.gbxGoma.Text = "Goma";
            // 
            // gbxSacapunta
            // 
            this.gbxSacapunta.Controls.Add(this.lblMarcaSacapunta);
            this.gbxSacapunta.Controls.Add(this.cbxMateriaSacapunta);
            this.gbxSacapunta.Controls.Add(this.btnAgregarSacapunta);
            this.gbxSacapunta.Controls.Add(this.txtMarcaSacapunta);
            this.gbxSacapunta.Controls.Add(this.lblMaterialSacapunta);
            this.gbxSacapunta.Controls.Add(this.nupdPrecioSacapunta);
            this.gbxSacapunta.Controls.Add(this.lblColorSacapunta);
            this.gbxSacapunta.Controls.Add(this.lblPrecioSacapunta);
            this.gbxSacapunta.Controls.Add(this.txtColorSacapunta);
            this.gbxSacapunta.Location = new System.Drawing.Point(580, 36);
            this.gbxSacapunta.Name = "gbxSacapunta";
            this.gbxSacapunta.Size = new System.Drawing.Size(180, 383);
            this.gbxSacapunta.TabIndex = 38;
            this.gbxSacapunta.TabStop = false;
            this.gbxSacapunta.Text = "Sacapunta";
            // 
            // FrmMenuAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 596);
            this.Controls.Add(this.gbxSacapunta);
            this.Controls.Add(this.gbxGoma);
            this.Controls.Add(this.gbxLapiz);
            this.Controls.Add(this.btnCambiarCapacidad);
            this.Controls.Add(this.nupdCapacidad);
            this.Controls.Add(this.lblNuevaCapacidad);
            this.Controls.Add(this.lblCapacidadActual);
            this.Name = "FrmMenuAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Agregar";
            this.Load += new System.EventHandler(this.FrmMenuAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupdCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPrecioLapiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPrecioGoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPrecioSacapunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdTamanioGoma)).EndInit();
            this.gbxLapiz.ResumeLayout(false);
            this.gbxLapiz.PerformLayout();
            this.gbxGoma.ResumeLayout(false);
            this.gbxGoma.PerformLayout();
            this.gbxSacapunta.ResumeLayout(false);
            this.gbxSacapunta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarLapiz;
        private Button btnAgregarGoma;
        private Button btnAgregarSacapunta;
        private Label lblCapacidadActual;
        private Label lblNuevaCapacidad;
        private NumericUpDown nupdCapacidad;
        private Button btnCambiarCapacidad;
        private TextBox txtMarcaLapiz;
        private NumericUpDown nupdPrecioLapiz;
        private Label lblMarcaLapiz;
        private Label lblPrecioLapiz;
        private Label lblColorLapiz;
        private TextBox txtColorLapiz;
        private Label lblPrecioGoma;
        private Label lblMarcaGoma;
        private NumericUpDown nupdPrecioGoma;
        private TextBox txtMarcaGoma;
        private Label lblPrecioSacapunta;
        private Label lblMarcaSacapunta;
        private NumericUpDown nupdPrecioSacapunta;
        private TextBox txtMarcaSacapunta;
        private Label lblTamanioGoma;
        private NumericUpDown nupdTamanioGoma;
        private Label lblColorGoma;
        private TextBox txtColorGoma;
        private Label lblColorSacapunta;
        private TextBox txtColorSacapunta;
        private Label lblMaterialSacapunta;
        private Label lblTrazoLapiz;
        private GroupBox gbxLapiz;
        private ComboBox cbxTrazoLapiz;
        private ComboBox cbxMateriaSacapunta;
        private GroupBox gbxGoma;
        private GroupBox gbxSacapunta;
    }
}