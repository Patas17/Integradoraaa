namespace ProyectoIntegrador1
{
    partial class SeguimientoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeguimientoForm));
            menuStrip2 = new MenuStrip();
            MenuCatalogo = new ToolStripMenuItem();
            MenuAgregarPlanta = new ToolStripMenuItem();
            MenuFavoritos = new ToolStripMenuItem();
            MenuSeguimiento = new ToolStripMenuItem();
            MenuUsuarios = new ToolStripMenuItem();
            txtFertilizante = new TextBox();
            txtSuelo = new TextBox();
            txtTemp = new TextBox();
            txtRiego = new TextBox();
            txtLuz = new TextBox();
            lblLugarApropiado = new Label();
            lblFertilizantes = new Label();
            lblSuelo = new Label();
            lblTemperatura = new Label();
            lblRiego = new Label();
            lblLuz = new Label();
            txtLugar = new TextBox();
            lblNombre = new Label();
            picImagen = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbRegadoSi = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            rbFertilSi = new RadioButton();
            txtUbicacion = new TextBox();
            label8 = new Label();
            lbl_Genero = new Label();
            txtTempMarcada = new TextBox();
            label6 = new Label();
            lbl_Especie = new Label();
            btnHistorial = new Button();
            btnGuardar = new Button();
            txtFechaActual = new TextBox();
            label7 = new Label();
            txtFechaInicio = new TextBox();
            label9 = new Label();
            txtDescripcion = new TextBox();
            label10 = new Label();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("Sitka Small", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.GripStyle = ToolStripGripStyle.Visible;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { MenuCatalogo, MenuAgregarPlanta, MenuFavoritos, MenuSeguimiento, MenuUsuarios });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1284, 27);
            menuStrip2.TabIndex = 40;
            menuStrip2.Text = "menuStrip2";
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
            // MenuSeguimiento
            // 
            MenuSeguimiento.Name = "MenuSeguimiento";
            MenuSeguimiento.Size = new Size(102, 23);
            MenuSeguimiento.Text = "Seguimiento";
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(73, 23);
            MenuUsuarios.Text = "Usuario";
            MenuUsuarios.Click += MenuUsuarios_Click;
            // 
            // txtFertilizante
            // 
            txtFertilizante.Font = new Font("Arial", 12F);
            txtFertilizante.Location = new Point(930, 401);
            txtFertilizante.Margin = new Padding(2);
            txtFertilizante.Multiline = true;
            txtFertilizante.Name = "txtFertilizante";
            txtFertilizante.Size = new Size(189, 92);
            txtFertilizante.TabIndex = 67;
            // 
            // txtSuelo
            // 
            txtSuelo.Font = new Font("Arial", 12F);
            txtSuelo.Location = new Point(533, 511);
            txtSuelo.Margin = new Padding(2);
            txtSuelo.Multiline = true;
            txtSuelo.Name = "txtSuelo";
            txtSuelo.Size = new Size(189, 92);
            txtSuelo.TabIndex = 66;
            // 
            // txtTemp
            // 
            txtTemp.Font = new Font("Arial", 12F);
            txtTemp.Location = new Point(533, 401);
            txtTemp.Margin = new Padding(2);
            txtTemp.Multiline = true;
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(189, 92);
            txtTemp.TabIndex = 65;
            // 
            // txtRiego
            // 
            txtRiego.Font = new Font("Arial", 12F);
            txtRiego.Location = new Point(153, 511);
            txtRiego.Margin = new Padding(2);
            txtRiego.Multiline = true;
            txtRiego.Name = "txtRiego";
            txtRiego.Size = new Size(189, 92);
            txtRiego.TabIndex = 64;
            // 
            // txtLuz
            // 
            txtLuz.Font = new Font("Arial", 12F);
            txtLuz.Location = new Point(153, 401);
            txtLuz.Margin = new Padding(2);
            txtLuz.Multiline = true;
            txtLuz.Name = "txtLuz";
            txtLuz.Size = new Size(189, 92);
            txtLuz.TabIndex = 63;
            // 
            // lblLugarApropiado
            // 
            lblLugarApropiado.AutoSize = true;
            lblLugarApropiado.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLugarApropiado.Location = new Point(765, 547);
            lblLugarApropiado.Margin = new Padding(2, 0, 2, 0);
            lblLugarApropiado.Name = "lblLugarApropiado";
            lblLugarApropiado.Size = new Size(139, 21);
            lblLugarApropiado.TabIndex = 62;
            lblLugarApropiado.Text = "6. Interior/Exterior:";
            // 
            // lblFertilizantes
            // 
            lblFertilizantes.AutoSize = true;
            lblFertilizantes.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFertilizantes.Location = new Point(770, 439);
            lblFertilizantes.Margin = new Padding(2, 0, 2, 0);
            lblFertilizantes.Name = "lblFertilizantes";
            lblFertilizantes.Size = new Size(112, 21);
            lblFertilizantes.TabIndex = 61;
            lblFertilizantes.Text = "5. Fertilizantes:";
            // 
            // lblSuelo
            // 
            lblSuelo.AutoSize = true;
            lblSuelo.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuelo.Location = new Point(394, 547);
            lblSuelo.Margin = new Padding(2, 0, 2, 0);
            lblSuelo.Name = "lblSuelo";
            lblSuelo.Size = new Size(68, 21);
            lblSuelo.TabIndex = 60;
            lblSuelo.Text = "4. Suelo:";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemperatura.Location = new Point(394, 437);
            lblTemperatura.Margin = new Padding(2, 0, 2, 0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(118, 21);
            lblTemperatura.TabIndex = 59;
            lblTemperatura.Text = "3. Temperatura:";
            // 
            // lblRiego
            // 
            lblRiego.AutoSize = true;
            lblRiego.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRiego.Location = new Point(48, 547);
            lblRiego.Margin = new Padding(2, 0, 2, 0);
            lblRiego.Name = "lblRiego";
            lblRiego.Size = new Size(69, 21);
            lblRiego.TabIndex = 58;
            lblRiego.Text = "2. Riego:";
            // 
            // lblLuz
            // 
            lblLuz.AutoSize = true;
            lblLuz.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLuz.Location = new Point(48, 437);
            lblLuz.Margin = new Padding(2, 0, 2, 0);
            lblLuz.Name = "lblLuz";
            lblLuz.Size = new Size(53, 21);
            lblLuz.TabIndex = 57;
            lblLuz.Text = "1. Luz:";
            // 
            // txtLugar
            // 
            txtLugar.Font = new Font("Arial", 12F);
            txtLugar.Location = new Point(930, 542);
            txtLugar.Margin = new Padding(2);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(189, 26);
            txtLugar.TabIndex = 68;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Historic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(35, 77, 50);
            lblNombre.Location = new Point(33, 297);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 40);
            lblNombre.TabIndex = 70;
            lblNombre.Text = "Planta 1";
            // 
            // picImagen
            // 
            picImagen.ErrorImage = (Image)resources.GetObject("picImagen.ErrorImage");
            picImagen.Image = Properties.Resources.Captura_de_pantalla_2025_07_02_090453;
            picImagen.InitialImage = (Image)resources.GetObject("picImagen.InitialImage");
            picImagen.Location = new Point(33, 74);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(258, 204);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagen.TabIndex = 69;
            picImagen.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 77, 50);
            label1.Location = new Point(33, 357);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 71;
            label1.Text = "Recomendaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(35, 77, 50);
            label2.Location = new Point(654, 112);
            label2.Name = "label2";
            label2.Size = new Size(298, 32);
            label2.TabIndex = 72;
            label2.Text = "Ingrese los datos del día";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(883, 281);
            label3.Name = "label3";
            label3.Size = new Size(0, 22);
            label3.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(654, 167);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 74;
            label4.Text = "Regué la planta: ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(654, 225);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 75;
            label5.Text = "Fertilizante utilizado:";
            label5.Click += label5_Click;
            // 
            // rbRegadoSi
            // 
            rbRegadoSi.AutoSize = true;
            rbRegadoSi.Location = new Point(19, 18);
            rbRegadoSi.Margin = new Padding(2);
            rbRegadoSi.Name = "rbRegadoSi";
            rbRegadoSi.Size = new Size(34, 19);
            rbRegadoSi.TabIndex = 76;
            rbRegadoSi.TabStop = true;
            rbRegadoSi.Text = "Si";
            rbRegadoSi.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(73, 18);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 77;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(rbRegadoSi);
            groupBox1.Location = new Point(838, 145);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(134, 40);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(rbFertilSi);
            groupBox2.Location = new Point(838, 208);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(134, 40);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(73, 18);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(41, 19);
            radioButton3.TabIndex = 77;
            radioButton3.TabStop = true;
            radioButton3.Text = "No";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbFertilSi
            // 
            rbFertilSi.AutoSize = true;
            rbFertilSi.Location = new Point(19, 18);
            rbFertilSi.Margin = new Padding(2);
            rbFertilSi.Name = "rbFertilSi";
            rbFertilSi.Size = new Size(34, 19);
            rbFertilSi.TabIndex = 76;
            rbFertilSi.TabStop = true;
            rbFertilSi.Text = "Si";
            rbFertilSi.UseVisualStyleBackColor = true;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font("Arial", 12F);
            txtUbicacion.Location = new Point(1117, 218);
            txtUbicacion.Margin = new Padding(2);
            txtUbicacion.Multiline = true;
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(127, 26);
            txtUbicacion.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1221, 202);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 86;
            // 
            // lbl_Genero
            // 
            lbl_Genero.AutoSize = true;
            lbl_Genero.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Genero.Location = new Point(993, 225);
            lbl_Genero.Margin = new Padding(2, 0, 2, 0);
            lbl_Genero.Name = "lbl_Genero";
            lbl_Genero.Size = new Size(78, 21);
            lbl_Genero.TabIndex = 85;
            lbl_Genero.Text = "Ubicacion";
            lbl_Genero.Click += lbl_Genero_Click;
            // 
            // txtTempMarcada
            // 
            txtTempMarcada.Font = new Font("Arial", 12F);
            txtTempMarcada.Location = new Point(1117, 156);
            txtTempMarcada.Margin = new Padding(2);
            txtTempMarcada.Multiline = true;
            txtTempMarcada.Name = "txtTempMarcada";
            txtTempMarcada.Size = new Size(127, 26);
            txtTempMarcada.TabIndex = 84;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(1197, 157);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 83;
            // 
            // lbl_Especie
            // 
            lbl_Especie.AutoSize = true;
            lbl_Especie.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Especie.Location = new Point(993, 152);
            lbl_Especie.Margin = new Padding(2, 0, 2, 0);
            lbl_Especie.Name = "lbl_Especie";
            lbl_Especie.Size = new Size(103, 42);
            lbl_Especie.TabIndex = 82;
            lbl_Especie.Text = "Temperatura \r\nMarcada:";
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(59, 119, 80);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = SystemColors.ControlLight;
            btnHistorial.Location = new Point(748, 297);
            btnHistorial.Margin = new Padding(2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(234, 35);
            btnHistorial.TabIndex = 88;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(59, 119, 80);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.Location = new Point(1010, 297);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(234, 35);
            btnGuardar.TabIndex = 89;
            btnGuardar.Text = "Guardar registro";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtFechaActual
            // 
            txtFechaActual.Enabled = false;
            txtFechaActual.Font = new Font("Arial", 12F);
            txtFechaActual.Location = new Point(821, 51);
            txtFechaActual.Margin = new Padding(2);
            txtFechaActual.Multiline = true;
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(127, 26);
            txtFechaActual.TabIndex = 91;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(697, 59);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 90;
            label7.Text = "Fecha Actual";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Enabled = false;
            txtFechaInicio.Font = new Font("Arial", 12F);
            txtFechaInicio.Location = new Point(1117, 51);
            txtFechaInicio.Margin = new Padding(2);
            txtFechaInicio.Multiline = true;
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(127, 26);
            txtFechaInicio.TabIndex = 93;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(980, 59);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(112, 21);
            label9.TabIndex = 92;
            label9.Text = "Fecha de Inicio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(330, 152);
            txtDescripcion.Margin = new Padding(2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(230, 125);
            txtDescripcion.TabIndex = 94;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(35, 77, 50);
            label10.Location = new Point(330, 93);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(132, 30);
            label10.TabIndex = 95;
            label10.Text = "Descripcion";
            // 
            // SeguimientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 243, 236);
            ClientSize = new Size(1284, 608);
            Controls.Add(label10);
            Controls.Add(txtDescripcion);
            Controls.Add(txtFechaInicio);
            Controls.Add(label9);
            Controls.Add(txtFechaActual);
            Controls.Add(label7);
            Controls.Add(btnGuardar);
            Controls.Add(btnHistorial);
            Controls.Add(txtUbicacion);
            Controls.Add(label8);
            Controls.Add(lbl_Genero);
            Controls.Add(txtTempMarcada);
            Controls.Add(label6);
            Controls.Add(lbl_Especie);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(picImagen);
            Controls.Add(txtLugar);
            Controls.Add(txtFertilizante);
            Controls.Add(txtSuelo);
            Controls.Add(txtTemp);
            Controls.Add(txtRiego);
            Controls.Add(txtLuz);
            Controls.Add(lblLugarApropiado);
            Controls.Add(lblFertilizantes);
            Controls.Add(lblSuelo);
            Controls.Add(lblTemperatura);
            Controls.Add(lblRiego);
            Controls.Add(lblLuz);
            Controls.Add(menuStrip2);
            Margin = new Padding(2);
            Name = "SeguimientoForm";
            Text = "Seguimiento";
            WindowState = FormWindowState.Maximized;
            Load += SeguimientoForm_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
		private ToolStripMenuItem MenuCatalogo;
		private ToolStripMenuItem MenuAgregarPlanta;
		private ToolStripMenuItem MenuFavoritos;
		private ToolStripMenuItem MenuSeguimiento;
		private ToolStripMenuItem MenuUsuarios;
		private TextBox txtFertilizante;
		private TextBox txtSuelo;
		private TextBox txtTemp;
		private TextBox txtRiego;
		private TextBox txtLuz;
		private Label lblLugarApropiado;
		private Label lblFertilizantes;
		private Label lblSuelo;
		private Label lblTemperatura;
		private Label lblRiego;
		private Label lblLuz;
		private TextBox txtLugar;
		private Label lblNombre;
		private PictureBox picImagen;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private RadioButton rbRegadoSi;
		private RadioButton radioButton2;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private RadioButton radioButton3;
		private RadioButton rbFertilSi;
		private TextBox txtUbicacion;
		private Label label8;
		private Label lbl_Genero;
		private TextBox txtTempMarcada;
		private Label label6;
		private Label lbl_Especie;
		private Button btnHistorial;
		private Button btnGuardar;
		private TextBox txtFechaActual;
		private Label label7;
		private TextBox txtFechaInicio;
		private Label label9;
		private TextBox txtDescripcion;
		private Label label10;
	}
}