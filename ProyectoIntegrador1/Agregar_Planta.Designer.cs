namespace Flower_Grow
{
	partial class Agregar_Planta
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
            lbl_Titulo = new Label();
            lbl_Subtitulo = new Label();
            lblClasificacion = new Label();
            lbl_Especie = new Label();
            label5 = new Label();
            lbl_Clase = new Label();
            txt_Especie = new TextBox();
            txt_Clase = new TextBox();
            txt_Division = new TextBox();
            txtGenero = new TextBox();
            lbl_Division = new Label();
            label8 = new Label();
            lbl_Genero = new Label();
            txt_Orden = new TextBox();
            txt_Familia = new TextBox();
            lbl_Orden = new Label();
            label11 = new Label();
            lbl_Familia = new Label();
            lbl_Caracteristicas = new Label();
            txt_Tamaño = new TextBox();
            label15 = new Label();
            lbl_Tamaño = new Label();
            label18 = new Label();
            btn_Guardar = new Button();
            btn_Actualizar = new Button();
            btn_Eliminar = new Button();
            btn_Buscar = new Button();
            lbl_Datos = new Label();
            lbl_Nombre = new Label();
            txt_Nombre = new TextBox();
            menu = new MenuStrip();
            MenuCatalogo = new ToolStripMenuItem();
            MenuAgregarPlanta = new ToolStripMenuItem();
            MenuFavoritos = new ToolStripMenuItem();
            MenuUsuarios = new ToolStripMenuItem();
            txt_Descripcion = new TextBox();
            lblDescripcion = new Label();
            lblTiposCuidado = new Label();
            lblLuz = new Label();
            lblRiego = new Label();
            lblTemperatura = new Label();
            lblLugarApropiado = new Label();
            lblFertilizantes = new Label();
            lblSuelo = new Label();
            txtLuz = new TextBox();
            txtRiego = new TextBox();
            txtTemperatura = new TextBox();
            txtSuelo = new TextBox();
            txt_Fertilizante = new TextBox();
            cmbLugar = new ComboBox();
            lblPlanta = new Label();
            txt_ID = new TextBox();
            btn_Borrar = new Button();
            lblfoto = new Label();
            ptbImagen = new PictureBox();
            btnCargarImagen = new Button();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).BeginInit();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Location = new Point(134, 109);
            lbl_Titulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(0, 15);
            lbl_Titulo.TabIndex = 0;
            // 
            // lbl_Subtitulo
            // 
            lbl_Subtitulo.AutoSize = true;
            lbl_Subtitulo.Location = new Point(239, 32);
            lbl_Subtitulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Subtitulo.Name = "lbl_Subtitulo";
            lbl_Subtitulo.Size = new Size(0, 15);
            lbl_Subtitulo.TabIndex = 1;
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClasificacion.ForeColor = Color.FromArgb(35, 77, 50);
            lblClasificacion.Location = new Point(349, 58);
            lblClasificacion.Margin = new Padding(2, 0, 2, 0);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(223, 25);
            lblClasificacion.TabIndex = 2;
            lblClasificacion.Text = "Clasificación cientifica";
            // 
            // lbl_Especie
            // 
            lbl_Especie.AutoSize = true;
            lbl_Especie.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Especie.Location = new Point(349, 98);
            lbl_Especie.Margin = new Padding(2, 0, 2, 0);
            lbl_Especie.Name = "lbl_Especie";
            lbl_Especie.Size = new Size(64, 21);
            lbl_Especie.TabIndex = 3;
            lbl_Especie.Text = "Especie:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 76);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // lbl_Clase
            // 
            lbl_Clase.AutoSize = true;
            lbl_Clase.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Clase.Location = new Point(571, 162);
            lbl_Clase.Margin = new Padding(2, 0, 2, 0);
            lbl_Clase.Name = "lbl_Clase";
            lbl_Clase.Size = new Size(50, 21);
            lbl_Clase.TabIndex = 5;
            lbl_Clase.Text = "Clase:";
            // 
            // txt_Especie
            // 
            txt_Especie.Font = new Font("Arial", 12F);
            txt_Especie.Location = new Point(428, 98);
            txt_Especie.Margin = new Padding(2);
            txt_Especie.Multiline = true;
            txt_Especie.Name = "txt_Especie";
            txt_Especie.Size = new Size(127, 26);
            txt_Especie.TabIndex = 6;
            // 
            // txt_Clase
            // 
            txt_Clase.Font = new Font("Arial", 12F);
            txt_Clase.Location = new Point(654, 157);
            txt_Clase.Margin = new Padding(2);
            txt_Clase.Multiline = true;
            txt_Clase.Name = "txt_Clase";
            txt_Clase.Size = new Size(127, 26);
            txt_Clase.TabIndex = 7;
            // 
            // txt_Division
            // 
            txt_Division.Font = new Font("Arial", 12F);
            txt_Division.Location = new Point(654, 219);
            txt_Division.Margin = new Padding(2);
            txt_Division.Multiline = true;
            txt_Division.Name = "txt_Division";
            txt_Division.Size = new Size(127, 26);
            txt_Division.TabIndex = 12;
            txt_Division.TextChanged += txt_Division_TextChanged;
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Arial", 12F);
            txtGenero.Location = new Point(428, 157);
            txtGenero.Margin = new Padding(2);
            txtGenero.Multiline = true;
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(127, 26);
            txtGenero.TabIndex = 11;
            // 
            // lbl_Division
            // 
            lbl_Division.AutoSize = true;
            lbl_Division.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Division.Location = new Point(571, 224);
            lbl_Division.Margin = new Padding(2, 0, 2, 0);
            lbl_Division.Name = "lbl_Division";
            lbl_Division.Size = new Size(69, 21);
            lbl_Division.TabIndex = 10;
            lbl_Division.Text = "División:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(555, 120);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 9;
            // 
            // lbl_Genero
            // 
            lbl_Genero.AutoSize = true;
            lbl_Genero.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Genero.Location = new Point(349, 158);
            lbl_Genero.Margin = new Padding(2, 0, 2, 0);
            lbl_Genero.Name = "lbl_Genero";
            lbl_Genero.Size = new Size(64, 21);
            lbl_Genero.TabIndex = 8;
            lbl_Genero.Text = "Género:";
            lbl_Genero.Click += lbl_Genero_Click;
            // 
            // txt_Orden
            // 
            txt_Orden.Font = new Font("Arial", 12F);
            txt_Orden.Location = new Point(654, 98);
            txt_Orden.Margin = new Padding(2);
            txt_Orden.Multiline = true;
            txt_Orden.Name = "txt_Orden";
            txt_Orden.Size = new Size(127, 26);
            txt_Orden.TabIndex = 17;
            // 
            // txt_Familia
            // 
            txt_Familia.Font = new Font("Arial", 12F);
            txt_Familia.Location = new Point(428, 219);
            txt_Familia.Margin = new Padding(2);
            txt_Familia.Multiline = true;
            txt_Familia.Name = "txt_Familia";
            txt_Familia.Size = new Size(127, 26);
            txt_Familia.TabIndex = 16;
            // 
            // lbl_Orden
            // 
            lbl_Orden.AutoSize = true;
            lbl_Orden.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Orden.Location = new Point(571, 103);
            lbl_Orden.Margin = new Padding(2, 0, 2, 0);
            lbl_Orden.Name = "lbl_Orden";
            lbl_Orden.Size = new Size(57, 21);
            lbl_Orden.TabIndex = 15;
            lbl_Orden.Text = "Orden:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1166, 60);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 14;
            // 
            // lbl_Familia
            // 
            lbl_Familia.AutoSize = true;
            lbl_Familia.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Familia.Location = new Point(349, 230);
            lbl_Familia.Margin = new Padding(2, 0, 2, 0);
            lbl_Familia.Name = "lbl_Familia";
            lbl_Familia.Size = new Size(63, 21);
            lbl_Familia.TabIndex = 13;
            lbl_Familia.Text = "Familia:";
            // 
            // lbl_Caracteristicas
            // 
            lbl_Caracteristicas.AutoSize = true;
            lbl_Caracteristicas.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Caracteristicas.ForeColor = Color.FromArgb(35, 77, 50);
            lbl_Caracteristicas.Location = new Point(824, 58);
            lbl_Caracteristicas.Margin = new Padding(2, 0, 2, 0);
            lbl_Caracteristicas.Name = "lbl_Caracteristicas";
            lbl_Caracteristicas.Size = new Size(149, 26);
            lbl_Caracteristicas.TabIndex = 18;
            lbl_Caracteristicas.Text = "Características";
            // 
            // txt_Tamaño
            // 
            txt_Tamaño.Font = new Font("Arial", 12F);
            txt_Tamaño.Location = new Point(905, 102);
            txt_Tamaño.Margin = new Padding(2);
            txt_Tamaño.Name = "txt_Tamaño";
            txt_Tamaño.Size = new Size(127, 26);
            txt_Tamaño.TabIndex = 22;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(762, 153);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 20;
            // 
            // lbl_Tamaño
            // 
            lbl_Tamaño.AutoSize = true;
            lbl_Tamaño.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Tamaño.Location = new Point(825, 103);
            lbl_Tamaño.Margin = new Padding(2, 0, 2, 0);
            lbl_Tamaño.Name = "lbl_Tamaño";
            lbl_Tamaño.Size = new Size(69, 21);
            lbl_Tamaño.TabIndex = 19;
            lbl_Tamaño.Text = "Tamaño:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(953, 157);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(0, 15);
            label18.TabIndex = 25;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(59, 119, 80);
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Guardar.ForeColor = SystemColors.ControlLight;
            btn_Guardar.Location = new Point(699, 549);
            btn_Guardar.Margin = new Padding(2);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(174, 37);
            btn_Guardar.TabIndex = 29;
            btn_Guardar.Text = "Guardar Planta";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.BackColor = Color.FromArgb(59, 119, 80);
            btn_Actualizar.FlatStyle = FlatStyle.Flat;
            btn_Actualizar.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Actualizar.ForeColor = SystemColors.ControlLight;
            btn_Actualizar.Location = new Point(895, 549);
            btn_Actualizar.Margin = new Padding(2);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(174, 37);
            btn_Actualizar.TabIndex = 30;
            btn_Actualizar.Text = "Actualizar Planta";
            btn_Actualizar.UseVisualStyleBackColor = false;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(59, 119, 80);
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Eliminar.ForeColor = SystemColors.ControlLight;
            btn_Eliminar.Location = new Point(1090, 549);
            btn_Eliminar.Margin = new Padding(2);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(174, 37);
            btn_Eliminar.TabIndex = 31;
            btn_Eliminar.Text = "Eliminar Planta";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.FromArgb(59, 119, 80);
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Buscar.ForeColor = SystemColors.ControlLight;
            btn_Buscar.Location = new Point(499, 549);
            btn_Buscar.Margin = new Padding(2);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(174, 37);
            btn_Buscar.TabIndex = 32;
            btn_Buscar.Text = "Buscar Planta";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // lbl_Datos
            // 
            lbl_Datos.AutoSize = true;
            lbl_Datos.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Datos.ForeColor = Color.FromArgb(35, 77, 50);
            lbl_Datos.Location = new Point(23, 58);
            lbl_Datos.Margin = new Padding(2, 0, 2, 0);
            lbl_Datos.Name = "lbl_Datos";
            lbl_Datos.Size = new Size(182, 25);
            lbl_Datos.TabIndex = 33;
            lbl_Datos.Text = "Datos de la planta";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nombre.Location = new Point(23, 109);
            lbl_Nombre.Margin = new Padding(2, 0, 2, 0);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(71, 21);
            lbl_Nombre.TabIndex = 35;
            lbl_Nombre.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Nombre.Location = new Point(128, 108);
            txt_Nombre.Margin = new Padding(2);
            txt_Nombre.Multiline = true;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Ejemplo: Palma Thrinax";
            txt_Nombre.Size = new Size(189, 26);
            txt_Nombre.TabIndex = 37;
            txt_Nombre.TextChanged += txt_Nombre_TextChanged;
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
            menu.TabIndex = 41;
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
            // txt_Descripcion
            // 
            txt_Descripcion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Descripcion.Location = new Point(128, 153);
            txt_Descripcion.Margin = new Padding(2);
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(189, 92);
            txt_Descripcion.TabIndex = 43;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(23, 157);
            lblDescripcion.Margin = new Padding(2, 0, 2, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(94, 21);
            lblDescripcion.TabIndex = 42;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblTiposCuidado
            // 
            lblTiposCuidado.AutoSize = true;
            lblTiposCuidado.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiposCuidado.ForeColor = Color.FromArgb(35, 77, 50);
            lblTiposCuidado.Location = new Point(30, 261);
            lblTiposCuidado.Margin = new Padding(2, 0, 2, 0);
            lblTiposCuidado.Name = "lblTiposCuidado";
            lblTiposCuidado.Size = new Size(181, 25);
            lblTiposCuidado.TabIndex = 44;
            lblTiposCuidado.Text = "Tipos de cuidados";
            // 
            // lblLuz
            // 
            lblLuz.AutoSize = true;
            lblLuz.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLuz.Location = new Point(23, 334);
            lblLuz.Margin = new Padding(2, 0, 2, 0);
            lblLuz.Name = "lblLuz";
            lblLuz.Size = new Size(53, 21);
            lblLuz.TabIndex = 45;
            lblLuz.Text = "1. Luz:";
            // 
            // lblRiego
            // 
            lblRiego.AutoSize = true;
            lblRiego.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRiego.Location = new Point(23, 456);
            lblRiego.Margin = new Padding(2, 0, 2, 0);
            lblRiego.Name = "lblRiego";
            lblRiego.Size = new Size(69, 21);
            lblRiego.TabIndex = 46;
            lblRiego.Text = "2. Riego:";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemperatura.Location = new Point(349, 334);
            lblTemperatura.Margin = new Padding(2, 0, 2, 0);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(118, 21);
            lblTemperatura.TabIndex = 47;
            lblTemperatura.Text = "3. Temperatura:";
            // 
            // lblLugarApropiado
            // 
            lblLugarApropiado.AutoSize = true;
            lblLugarApropiado.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLugarApropiado.Location = new Point(734, 456);
            lblLugarApropiado.Margin = new Padding(2, 0, 2, 0);
            lblLugarApropiado.Name = "lblLugarApropiado";
            lblLugarApropiado.Size = new Size(139, 21);
            lblLugarApropiado.TabIndex = 50;
            lblLugarApropiado.Text = "6. Interior/Exterior:";
            // 
            // lblFertilizantes
            // 
            lblFertilizantes.AutoSize = true;
            lblFertilizantes.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFertilizantes.Location = new Point(734, 334);
            lblFertilizantes.Margin = new Padding(2, 0, 2, 0);
            lblFertilizantes.Name = "lblFertilizantes";
            lblFertilizantes.Size = new Size(112, 21);
            lblFertilizantes.TabIndex = 49;
            lblFertilizantes.Text = "5. Fertilizantes:";
            // 
            // lblSuelo
            // 
            lblSuelo.AutoSize = true;
            lblSuelo.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuelo.Location = new Point(364, 456);
            lblSuelo.Margin = new Padding(2, 0, 2, 0);
            lblSuelo.Name = "lblSuelo";
            lblSuelo.Size = new Size(68, 21);
            lblSuelo.TabIndex = 48;
            lblSuelo.Text = "4. Suelo:";
            // 
            // txtLuz
            // 
            txtLuz.Font = new Font("Arial", 12F);
            txtLuz.Location = new Point(128, 297);
            txtLuz.Margin = new Padding(2);
            txtLuz.Multiline = true;
            txtLuz.Name = "txtLuz";
            txtLuz.Size = new Size(189, 92);
            txtLuz.TabIndex = 51;
            // 
            // txtRiego
            // 
            txtRiego.Font = new Font("Arial", 12F);
            txtRiego.Location = new Point(128, 424);
            txtRiego.Margin = new Padding(2);
            txtRiego.Multiline = true;
            txtRiego.Name = "txtRiego";
            txtRiego.Size = new Size(189, 92);
            txtRiego.TabIndex = 52;
            // 
            // txtTemperatura
            // 
            txtTemperatura.Font = new Font("Arial", 12F);
            txtTemperatura.Location = new Point(484, 297);
            txtTemperatura.Margin = new Padding(2);
            txtTemperatura.Multiline = true;
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(189, 92);
            txtTemperatura.TabIndex = 53;
            // 
            // txtSuelo
            // 
            txtSuelo.Font = new Font("Arial", 12F);
            txtSuelo.Location = new Point(484, 424);
            txtSuelo.Margin = new Padding(2);
            txtSuelo.Multiline = true;
            txtSuelo.Name = "txtSuelo";
            txtSuelo.Size = new Size(189, 92);
            txtSuelo.TabIndex = 54;
            // 
            // txt_Fertilizante
            // 
            txt_Fertilizante.Font = new Font("Arial", 12F);
            txt_Fertilizante.Location = new Point(895, 297);
            txt_Fertilizante.Margin = new Padding(2);
            txt_Fertilizante.Multiline = true;
            txt_Fertilizante.Name = "txt_Fertilizante";
            txt_Fertilizante.Size = new Size(189, 92);
            txt_Fertilizante.TabIndex = 55;
            // 
            // cmbLugar
            // 
            cmbLugar.Font = new Font("Arial", 12F);
            cmbLugar.FormattingEnabled = true;
            cmbLugar.Items.AddRange(new object[] { "Exterior", "Interior" });
            cmbLugar.Location = new Point(895, 455);
            cmbLugar.Margin = new Padding(2);
            cmbLugar.Name = "cmbLugar";
            cmbLugar.Size = new Size(189, 26);
            cmbLugar.TabIndex = 56;
            // 
            // lblPlanta
            // 
            lblPlanta.AutoSize = true;
            lblPlanta.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlanta.Location = new Point(30, 556);
            lblPlanta.Margin = new Padding(2, 0, 2, 0);
            lblPlanta.Name = "lblPlanta";
            lblPlanta.Size = new Size(68, 21);
            lblPlanta.TabIndex = 57;
            lblPlanta.Text = "IDPlanta";
            lblPlanta.Visible = false;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(128, 554);
            txt_ID.Margin = new Padding(2);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(73, 23);
            txt_ID.TabIndex = 58;
            txt_ID.Visible = false;
            // 
            // btn_Borrar
            // 
            btn_Borrar.BackColor = Color.FromArgb(59, 119, 80);
            btn_Borrar.FlatStyle = FlatStyle.Flat;
            btn_Borrar.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Borrar.ForeColor = Color.White;
            btn_Borrar.Location = new Point(302, 549);
            btn_Borrar.Margin = new Padding(2);
            btn_Borrar.Name = "btn_Borrar";
            btn_Borrar.Size = new Size(174, 37);
            btn_Borrar.TabIndex = 59;
            btn_Borrar.Text = "Borrar datos";
            btn_Borrar.UseVisualStyleBackColor = false;
            btn_Borrar.Click += btn_Borrar_Click;
            // 
            // lblfoto
            // 
            lblfoto.AutoSize = true;
            lblfoto.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfoto.Location = new Point(1118, 71);
            lblfoto.Margin = new Padding(2, 0, 2, 0);
            lblfoto.Name = "lblfoto";
            lblfoto.Size = new Size(65, 21);
            lblfoto.TabIndex = 61;
            lblfoto.Text = "Imagen:";
            // 
            // ptbImagen
            // 
            ptbImagen.Location = new Point(1066, 109);
            ptbImagen.Margin = new Padding(2);
            ptbImagen.Name = "ptbImagen";
            ptbImagen.Size = new Size(179, 97);
            ptbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            ptbImagen.TabIndex = 62;
            ptbImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackColor = Color.FromArgb(59, 119, 80);
            btnCargarImagen.FlatStyle = FlatStyle.Flat;
            btnCargarImagen.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarImagen.ForeColor = SystemColors.Control;
            btnCargarImagen.Location = new Point(1049, 222);
            btnCargarImagen.Margin = new Padding(2);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(215, 35);
            btnCargarImagen.TabIndex = 63;
            btnCargarImagen.Text = "Cargar imagen";
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // Agregar_Planta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 243, 236);
            ClientSize = new Size(1284, 608);
            Controls.Add(btnCargarImagen);
            Controls.Add(ptbImagen);
            Controls.Add(lblfoto);
            Controls.Add(btn_Borrar);
            Controls.Add(txt_ID);
            Controls.Add(lblPlanta);
            Controls.Add(cmbLugar);
            Controls.Add(txt_Fertilizante);
            Controls.Add(txtSuelo);
            Controls.Add(txtTemperatura);
            Controls.Add(txtRiego);
            Controls.Add(txtLuz);
            Controls.Add(lblLugarApropiado);
            Controls.Add(lblFertilizantes);
            Controls.Add(lblSuelo);
            Controls.Add(lblTemperatura);
            Controls.Add(lblRiego);
            Controls.Add(lblLuz);
            Controls.Add(lblTiposCuidado);
            Controls.Add(txt_Descripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(menu);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_Datos);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Actualizar);
            Controls.Add(btn_Guardar);
            Controls.Add(label18);
            Controls.Add(txt_Tamaño);
            Controls.Add(label15);
            Controls.Add(lbl_Tamaño);
            Controls.Add(lbl_Caracteristicas);
            Controls.Add(txt_Orden);
            Controls.Add(txt_Familia);
            Controls.Add(lbl_Orden);
            Controls.Add(label11);
            Controls.Add(lbl_Familia);
            Controls.Add(txt_Division);
            Controls.Add(txtGenero);
            Controls.Add(lbl_Division);
            Controls.Add(label8);
            Controls.Add(lbl_Genero);
            Controls.Add(txt_Clase);
            Controls.Add(txt_Especie);
            Controls.Add(lbl_Clase);
            Controls.Add(label5);
            Controls.Add(lbl_Especie);
            Controls.Add(lblClasificacion);
            Controls.Add(lbl_Subtitulo);
            Controls.Add(lbl_Titulo);
            Margin = new Padding(2);
            Name = "Agregar_Planta";
            Text = "Agregar Planta";
            WindowState = FormWindowState.Maximized;
            Load += Agregar_Planta_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
		private Label lbl_Subtitulo;
		private Label lblClasificacion;
		private Label lbl_Especie;
		private Label label5;
		private Label lbl_Clase;
		private TextBox txt_Especie;
		private TextBox txt_Clase;
		private TextBox txt_Division;
		private TextBox txtGenero;
		private Label lbl_Division;
		private Label label8;
		private Label lbl_Genero;
		private TextBox txt_Orden;
		private TextBox txt_Familia;
		private Label lbl_Orden;
		private Label label11;
		private Label lbl_Familia;
		private Label lbl_Caracteristicas;
		private TextBox txt_Tamaño;
		private Label label15;
		private Label lbl_Tamaño;
		private Label label18;
		private Button btn_Guardar;
		private Button btn_Actualizar;
		private Button btn_Eliminar;
		private Button btn_Buscar;
		private Label lbl_Datos;
		private Label lbl_Nombre;
		private TextBox txt_Nombre;
		private MenuStrip menu;
		private ToolStripMenuItem MenuCatalogo;
		private ToolStripMenuItem MenuAgregarPlanta;
		private ToolStripMenuItem MenuFavoritos;
		private ToolStripMenuItem MenuUsuarios;
		private TextBox txt_Descripcion;
		private Label lblDescripcion;
		private Label lblTiposCuidado;
		private Label lblLuz;
		private Label lblRiego;
		private Label lblTemperatura;
		private Label lblLugarApropiado;
		private Label lblFertilizantes;
		private Label lblSuelo;
		private TextBox txtLuz;
		private TextBox txtRiego;
		private TextBox txtTemperatura;
		private TextBox txtSuelo;
		private TextBox txt_Fertilizante;
		private ComboBox cmbLugar;
		private Label lblPlanta;
		private TextBox txt_ID;
		private Button btn_Borrar;
		private Label lblfoto;
		private PictureBox ptbImagen;
		private Button btnCargarImagen;
	}
}