namespace ProyectoIntegrador1
{
    partial class Conocer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conocer));
            menu = new MenuStrip();
            MenuCatalogo = new ToolStripMenuItem();
            MenuAgregarPlanta = new ToolStripMenuItem();
            MenuFavoritos = new ToolStripMenuItem();
            MenuUsuarios = new ToolStripMenuItem();
            panel1 = new Panel();
            txtLugarApropiado = new TextBox();
            txtDescripcion = new TextBox();
            lbl_Titulo = new Label();
            txtTamaño = new TextBox();
            lbl_Tamaño = new Label();
            txtFertilizante = new TextBox();
            txtSuelo = new TextBox();
            txtTemperatura = new TextBox();
            txtRiego = new TextBox();
            txtLuz = new TextBox();
            lblLugarApropiado = new Label();
            lblFertilizantes = new Label();
            lblSuelo = new Label();
            lblTemperatura = new Label();
            lblRiego = new Label();
            lblLuz = new Label();
            lblTiposCuidado = new Label();
            label1 = new Label();
            txtOrden = new TextBox();
            txtFamilia = new TextBox();
            lbl_Orden = new Label();
            lbl_Familia = new Label();
            txtDivision = new TextBox();
            txtGenero = new TextBox();
            lbl_Division = new Label();
            label8 = new Label();
            lbl_Genero = new Label();
            txtClase = new TextBox();
            txtEspecie = new TextBox();
            lbl_Clase = new Label();
            label5 = new Label();
            lbl_Especie = new Label();
            lblClasificacion = new Label();
            lblNombre = new Label();
            pictureBox = new PictureBox();
            lblTitulo = new Label();
            btnRegresar = new Button();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Font = new Font("Sitka Small", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.GripStyle = ToolStripGripStyle.Visible;
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { MenuCatalogo, MenuAgregarPlanta, MenuFavoritos, MenuUsuarios });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1284, 27);
            menu.TabIndex = 42;
            menu.Text = "menuStrip2";
            // 
            // MenuCatalogo
            // 
            MenuCatalogo.Name = "MenuCatalogo";
            MenuCatalogo.Size = new Size(80, 23);
            MenuCatalogo.Text = "Catálogo";
            MenuCatalogo.Click += MenuCatalogo_Click;
            // 
            // MenuAgregarPlanta
            // 
            MenuAgregarPlanta.Name = "MenuAgregarPlanta";
            MenuAgregarPlanta.Size = new Size(119, 23);
            MenuAgregarPlanta.Text = "Agregar planta";
            MenuAgregarPlanta.Click += MenuAgregarPlanta_Click;
            // 
            // MenuFavoritos
            // 
            MenuFavoritos.Name = "MenuFavoritos";
            MenuFavoritos.Size = new Size(84, 23);
            MenuFavoritos.Text = "Favoritos";
            MenuFavoritos.Click += MenuFavoritos_Click;
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(73, 23);
            MenuUsuarios.Text = "Usuario";
            MenuUsuarios.Click += MenuUsuarios_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 251, 247);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(txtLugarApropiado);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(lbl_Titulo);
            panel1.Controls.Add(txtTamaño);
            panel1.Controls.Add(lbl_Tamaño);
            panel1.Controls.Add(txtFertilizante);
            panel1.Controls.Add(txtSuelo);
            panel1.Controls.Add(txtTemperatura);
            panel1.Controls.Add(txtRiego);
            panel1.Controls.Add(txtLuz);
            panel1.Controls.Add(lblLugarApropiado);
            panel1.Controls.Add(lblFertilizantes);
            panel1.Controls.Add(lblSuelo);
            panel1.Controls.Add(lblTemperatura);
            panel1.Controls.Add(lblRiego);
            panel1.Controls.Add(lblLuz);
            panel1.Controls.Add(lblTiposCuidado);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtOrden);
            panel1.Controls.Add(txtFamilia);
            panel1.Controls.Add(lbl_Orden);
            panel1.Controls.Add(lbl_Familia);
            panel1.Controls.Add(txtDivision);
            panel1.Controls.Add(txtGenero);
            panel1.Controls.Add(lbl_Division);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lbl_Genero);
            panel1.Controls.Add(txtClase);
            panel1.Controls.Add(txtEspecie);
            panel1.Controls.Add(lbl_Clase);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbl_Especie);
            panel1.Controls.Add(lblClasificacion);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(39, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(1292, 553);
            panel1.TabIndex = 43;
            panel1.Paint += panel1_Paint;
            // 
            // txtLugarApropiado
            // 
            txtLugarApropiado.Enabled = false;
            txtLugarApropiado.Font = new Font("Arial", 12F);
            txtLugarApropiado.Location = new Point(1046, 425);
            txtLugarApropiado.Margin = new Padding(2);
            txtLugarApropiado.Multiline = true;
            txtLugarApropiado.Name = "txtLugarApropiado";
            txtLugarApropiado.Size = new Size(171, 26);
            txtLugarApropiado.TabIndex = 75;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(15, 278);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(207, 132);
            txtDescripcion.TabIndex = 74;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Enabled = false;
            lbl_Titulo.Location = new Point(180, 261);
            lbl_Titulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(0, 15);
            lbl_Titulo.TabIndex = 72;
            // 
            // txtTamaño
            // 
            txtTamaño.Enabled = false;
            txtTamaño.Font = new Font("Arial", 12F);
            txtTamaño.Location = new Point(95, 468);
            txtTamaño.Margin = new Padding(2);
            txtTamaño.Name = "txtTamaño";
            txtTamaño.Size = new Size(127, 26);
            txtTamaño.TabIndex = 71;
            // 
            // lbl_Tamaño
            // 
            lbl_Tamaño.AutoSize = true;
            lbl_Tamaño.Font = new Font("Arial", 12F);
            lbl_Tamaño.Location = new Point(16, 471);
            lbl_Tamaño.Margin = new Padding(2, 0, 2, 0);
            lbl_Tamaño.Name = "lbl_Tamaño";
            lbl_Tamaño.Size = new Size(67, 18);
            lbl_Tamaño.TabIndex = 70;
            lbl_Tamaño.Text = "Tamaño:";
            // 
            // txtFertilizante
            // 
            txtFertilizante.Enabled = false;
            txtFertilizante.Font = new Font("Arial", 12F);
            txtFertilizante.Location = new Point(1028, 243);
            txtFertilizante.Margin = new Padding(2);
            txtFertilizante.Multiline = true;
            txtFertilizante.Name = "txtFertilizante";
            txtFertilizante.Size = new Size(189, 92);
            txtFertilizante.TabIndex = 68;
            // 
            // txtSuelo
            // 
            txtSuelo.Enabled = false;
            txtSuelo.Font = new Font("Arial", 12F);
            txtSuelo.Location = new Point(645, 392);
            txtSuelo.Margin = new Padding(2);
            txtSuelo.Multiline = true;
            txtSuelo.Name = "txtSuelo";
            txtSuelo.Size = new Size(189, 92);
            txtSuelo.TabIndex = 67;
            // 
            // txtTemperatura
            // 
            txtTemperatura.Enabled = false;
            txtTemperatura.Font = new Font("Arial", 12F);
            txtTemperatura.Location = new Point(645, 243);
            txtTemperatura.Margin = new Padding(2);
            txtTemperatura.Multiline = true;
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(189, 92);
            txtTemperatura.TabIndex = 66;
            txtTemperatura.TextChanged += txtTemperatura_TextChanged;
            // 
            // txtRiego
            // 
            txtRiego.Enabled = false;
            txtRiego.Font = new Font("Arial", 12F);
            txtRiego.Location = new Point(321, 397);
            txtRiego.Margin = new Padding(2);
            txtRiego.Multiline = true;
            txtRiego.Name = "txtRiego";
            txtRiego.Size = new Size(189, 92);
            txtRiego.TabIndex = 65;
            // 
            // txtLuz
            // 
            txtLuz.Enabled = false;
            txtLuz.Font = new Font("Arial", 12F);
            txtLuz.Location = new Point(321, 243);
            txtLuz.Margin = new Padding(2);
            txtLuz.Multiline = true;
            txtLuz.Name = "txtLuz";
            txtLuz.Size = new Size(189, 92);
            txtLuz.TabIndex = 64;
            // 
            // lblLugarApropiado
            // 
            lblLugarApropiado.AutoSize = true;
            lblLugarApropiado.Font = new Font("Arial", 12F);
            lblLugarApropiado.Location = new Point(895, 428);
            lblLugarApropiado.Margin = new Padding(2, 0, 2, 0);
            lblLugarApropiado.Name = "lblLugarApropiado";
            lblLugarApropiado.Size = new Size(134, 18);
            lblLugarApropiado.TabIndex = 63;
            lblLugarApropiado.Text = "6. Interior/Exterior:";
            // 
            // lblFertilizantes
            // 
            lblFertilizantes.AutoSize = true;
            lblFertilizantes.Font = new Font("Arial", 12F);
            lblFertilizantes.Location = new Point(895, 281);
            lblFertilizantes.Margin = new Padding(2, 0, 2, 0);
            lblFertilizantes.Name = "lblFertilizantes";
            lblFertilizantes.Size = new Size(113, 18);
            lblFertilizantes.TabIndex = 62;
            lblFertilizantes.Text = "5. Fertilizantes:";
            // 
            // lblSuelo
            // 
            lblSuelo.AutoSize = true;
            lblSuelo.Font = new Font("Arial", 12F);
            lblSuelo.Location = new Point(525, 433);
            lblSuelo.Margin = new Padding(2, 0, 2, 0);
            lblSuelo.Name = "lblSuelo";
            lblSuelo.Size = new Size(69, 18);
            lblSuelo.TabIndex = 61;
            lblSuelo.Text = "4. Suelo:";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Arial", 12F);
            lblTemperatura.Location = new Point(525, 281);
            lblTemperatura.Margin = new Padding(2, 0, 2, 0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(116, 18);
            lblTemperatura.TabIndex = 60;
            lblTemperatura.Text = "3. Temperatura:";
            // 
            // lblRiego
            // 
            lblRiego.AutoSize = true;
            lblRiego.Font = new Font("Arial", 12F);
            lblRiego.Location = new Point(242, 433);
            lblRiego.Margin = new Padding(2, 0, 2, 0);
            lblRiego.Name = "lblRiego";
            lblRiego.Size = new Size(71, 18);
            lblRiego.TabIndex = 59;
            lblRiego.Text = "2. Riego:";
            // 
            // lblLuz
            // 
            lblLuz.AutoSize = true;
            lblLuz.Font = new Font("Arial", 12F);
            lblLuz.Location = new Point(242, 281);
            lblLuz.Margin = new Padding(2, 0, 2, 0);
            lblLuz.Name = "lblLuz";
            lblLuz.Size = new Size(53, 18);
            lblLuz.TabIndex = 58;
            lblLuz.Text = "1. Luz:";
            // 
            // lblTiposCuidado
            // 
            lblTiposCuidado.AutoSize = true;
            lblTiposCuidado.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiposCuidado.ForeColor = Color.FromArgb(35, 77, 50);
            lblTiposCuidado.Location = new Point(244, 191);
            lblTiposCuidado.Margin = new Padding(2, 0, 2, 0);
            lblTiposCuidado.Name = "lblTiposCuidado";
            lblTiposCuidado.Size = new Size(197, 30);
            lblTiposCuidado.TabIndex = 57;
            lblTiposCuidado.Text = "Tipos de cuidados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(654, 136);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 36;
            // 
            // txtOrden
            // 
            txtOrden.Enabled = false;
            txtOrden.Font = new Font("Arial", 12F);
            txtOrden.Location = new Point(321, 115);
            txtOrden.Margin = new Padding(2);
            txtOrden.Multiline = true;
            txtOrden.Name = "txtOrden";
            txtOrden.Size = new Size(127, 26);
            txtOrden.TabIndex = 35;
            // 
            // txtFamilia
            // 
            txtFamilia.Enabled = false;
            txtFamilia.Font = new Font("Arial", 12F);
            txtFamilia.Location = new Point(824, 53);
            txtFamilia.Margin = new Padding(2);
            txtFamilia.Multiline = true;
            txtFamilia.Name = "txtFamilia";
            txtFamilia.Size = new Size(127, 26);
            txtFamilia.TabIndex = 34;
            // 
            // lbl_Orden
            // 
            lbl_Orden.AutoSize = true;
            lbl_Orden.Font = new Font("Arial", 12F);
            lbl_Orden.Location = new Point(244, 118);
            lbl_Orden.Margin = new Padding(2, 0, 2, 0);
            lbl_Orden.Name = "lbl_Orden";
            lbl_Orden.Size = new Size(55, 18);
            lbl_Orden.TabIndex = 33;
            lbl_Orden.Text = "Orden:";
            // 
            // lbl_Familia
            // 
            lbl_Familia.AutoSize = true;
            lbl_Familia.Font = new Font("Arial", 12F);
            lbl_Familia.Location = new Point(746, 59);
            lbl_Familia.Margin = new Padding(2, 0, 2, 0);
            lbl_Familia.Name = "lbl_Familia";
            lbl_Familia.Size = new Size(64, 18);
            lbl_Familia.TabIndex = 32;
            lbl_Familia.Text = "Familia:";
            // 
            // txtDivision
            // 
            txtDivision.Enabled = false;
            txtDivision.Font = new Font("Arial", 12F);
            txtDivision.Location = new Point(824, 125);
            txtDivision.Margin = new Padding(2);
            txtDivision.Multiline = true;
            txtDivision.Name = "txtDivision";
            txtDivision.Size = new Size(127, 26);
            txtDivision.TabIndex = 31;
            // 
            // txtGenero
            // 
            txtGenero.Enabled = false;
            txtGenero.Font = new Font("Arial", 12F);
            txtGenero.Location = new Point(583, 53);
            txtGenero.Margin = new Padding(2);
            txtGenero.Multiline = true;
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(127, 26);
            txtGenero.TabIndex = 30;
            txtGenero.TextChanged += txtGenero_TextChanged;
            // 
            // lbl_Division
            // 
            lbl_Division.AutoSize = true;
            lbl_Division.Font = new Font("Arial", 12F);
            lbl_Division.Location = new Point(746, 123);
            lbl_Division.Margin = new Padding(2, 0, 2, 0);
            lbl_Division.Name = "lbl_Division";
            lbl_Division.Size = new Size(64, 18);
            lbl_Division.TabIndex = 29;
            lbl_Division.Text = "División";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(448, 103);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 28;
            // 
            // lbl_Genero
            // 
            lbl_Genero.AutoSize = true;
            lbl_Genero.Font = new Font("Arial", 12F);
            lbl_Genero.Location = new Point(515, 59);
            lbl_Genero.Margin = new Padding(2, 0, 2, 0);
            lbl_Genero.Name = "lbl_Genero";
            lbl_Genero.Size = new Size(64, 18);
            lbl_Genero.TabIndex = 27;
            lbl_Genero.Text = "Género:";
            // 
            // txtClase
            // 
            txtClase.Enabled = false;
            txtClase.Font = new Font("Arial", 12F);
            txtClase.Location = new Point(583, 115);
            txtClase.Margin = new Padding(2);
            txtClase.Multiline = true;
            txtClase.Name = "txtClase";
            txtClase.Size = new Size(127, 26);
            txtClase.TabIndex = 26;
            // 
            // txtEspecie
            // 
            txtEspecie.Enabled = false;
            txtEspecie.Font = new Font("Arial", 12F);
            txtEspecie.Location = new Point(321, 56);
            txtEspecie.Margin = new Padding(2);
            txtEspecie.Multiline = true;
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(127, 26);
            txtEspecie.TabIndex = 25;
            // 
            // lbl_Clase
            // 
            lbl_Clase.AutoSize = true;
            lbl_Clase.Font = new Font("Arial", 12F);
            lbl_Clase.Location = new Point(515, 118);
            lbl_Clase.Margin = new Padding(2, 0, 2, 0);
            lbl_Clase.Name = "lbl_Clase";
            lbl_Clase.Size = new Size(53, 18);
            lbl_Clase.TabIndex = 24;
            lbl_Clase.Text = "Clase:";
            lbl_Clase.Click += lbl_Clase_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(424, 59);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 23;
            // 
            // lbl_Especie
            // 
            lbl_Especie.AutoSize = true;
            lbl_Especie.Font = new Font("Arial", 12F);
            lbl_Especie.Location = new Point(242, 65);
            lbl_Especie.Margin = new Padding(2, 0, 2, 0);
            lbl_Especie.Name = "lbl_Especie";
            lbl_Especie.Size = new Size(70, 18);
            lbl_Especie.TabIndex = 22;
            lbl_Especie.Text = "Especie:";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClasificacion.ForeColor = Color.FromArgb(35, 77, 50);
            lblClasificacion.Location = new Point(242, 24);
            lblClasificacion.Margin = new Padding(2, 0, 2, 0);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(241, 30);
            lblClasificacion.TabIndex = 21;
            lblClasificacion.Text = "Clasificación cientifica";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(35, 77, 50);
            lblNombre.Location = new Point(57, 213);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Planta 1";
            lblNombre.Click += lblNombre_Click;
            // 
            // pictureBox
            // 
            pictureBox.ErrorImage = (Image)resources.GetObject("pictureBox.ErrorImage");
            pictureBox.Image = Properties.Resources.Captura_de_pantalla_2025_07_02_090453;
            pictureBox.InitialImage = (Image)resources.GetObject("pictureBox.InitialImage");
            pictureBox.Location = new Point(16, 37);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(197, 156);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(35, 77, 50);
            lblTitulo.Location = new Point(509, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(306, 45);
            lblTitulo.TabIndex = 44;
            lblTitulo.Text = "Conoce a tu planta";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(59, 119, 80);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.ControlLight;
            btnRegresar.Location = new Point(1008, 506);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(207, 34);
            btnRegresar.TabIndex = 76;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Conocer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 243, 236);
            ClientSize = new Size(1284, 642);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Controls.Add(menu);
            Name = "Conocer";
            Text = "Conocer";
            WindowState = FormWindowState.Maximized;
            Load += Conocer_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
		private ToolStripMenuItem MenuCatalogo;
		private ToolStripMenuItem MenuAgregarPlanta;
		private ToolStripMenuItem MenuFavoritos;
		private ToolStripMenuItem MenuUsuarios;
		private Panel panel1;
		private Label lblNombre;
		private PictureBox pictureBox;
		private Label label1;
		private TextBox txtOrden;
		private TextBox txtFamilia;
		private Label lbl_Orden;
		private Label lbl_Familia;
		private TextBox txtDivision;
		private TextBox txtGenero;
		private Label lbl_Division;
		private Label label8;
		private Label lbl_Genero;
		private TextBox txtClase;
		private TextBox txtEspecie;
		private Label lbl_Clase;
		private Label label5;
		private Label lbl_Especie;
		private Label lblClasificacion;
		private TextBox txtFertilizante;
		private TextBox txtSuelo;
		private TextBox txtTemperatura;
		private TextBox txtRiego;
		private TextBox txtLuz;
		private Label lblLugarApropiado;
		private Label lblFertilizantes;
		private Label lblSuelo;
		private Label lblTemperatura;
		private Label lblRiego;
		private Label lblLuz;
		private Label lblTiposCuidado;
		private TextBox txtTamaño;
		private Label lbl_Tamaño;
		private TextBox txtDescripcion;
		private Label lbl_Titulo;
		private TextBox txtLugarApropiado;
		private Label lblTitulo;
        private Button btnRegresar;
    }
}