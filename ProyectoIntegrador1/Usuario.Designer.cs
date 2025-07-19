namespace ProyectoIntegrador1
{
	partial class Usuario
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
            menuStrip2 = new MenuStrip();
            MenuCatalogo = new ToolStripMenuItem();
            MenuAgregarPlanta = new ToolStripMenuItem();
            MenuFavoritos = new ToolStripMenuItem();
            MenuUsuarios = new ToolStripMenuItem();
            panel1 = new Panel();
            btncerrarses = new Button();
            txtNueva = new TextBox();
            txtActual = new TextBox();
            btnCambiar = new Button();
            lblCorreo = new Label();
            lblNombre = new Label();
            label1 = new Label();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("Sitka Small", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.GripStyle = ToolStripGripStyle.Visible;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { MenuCatalogo, MenuAgregarPlanta, MenuFavoritos, MenuUsuarios });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(663, 27);
            menuStrip2.TabIndex = 39;
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
            panel1.Controls.Add(btncerrarses);
            panel1.Controls.Add(txtNueva);
            panel1.Controls.Add(txtActual);
            panel1.Controls.Add(btnCambiar);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 397);
            panel1.TabIndex = 40;
            panel1.Paint += panel1_Paint;
            // 
            // btncerrarses
            // 
            btncerrarses.BackColor = Color.FromArgb(59, 119, 80);
            btncerrarses.FlatStyle = FlatStyle.Flat;
            btncerrarses.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncerrarses.ForeColor = SystemColors.ControlLight;
            btncerrarses.Location = new Point(136, 334);
            btncerrarses.Name = "btncerrarses";
            btncerrarses.Size = new Size(318, 42);
            btncerrarses.TabIndex = 6;
            btncerrarses.Text = "Cerrar sesion";
            btncerrarses.UseVisualStyleBackColor = false;
            btncerrarses.Click += button1_Click_1;
            // 
            // txtNueva
            // 
            txtNueva.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNueva.Location = new Point(136, 224);
            txtNueva.Name = "txtNueva";
            txtNueva.PlaceholderText = "Contraseña nueva";
            txtNueva.Size = new Size(318, 35);
            txtNueva.TabIndex = 5;
            // 
            // txtActual
            // 
            txtActual.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtActual.Location = new Point(136, 183);
            txtActual.Name = "txtActual";
            txtActual.PlaceholderText = "Contraseña actual";
            txtActual.Size = new Size(318, 35);
            txtActual.TabIndex = 4;
            txtActual.TextChanged += txtActual_TextChanged;
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.FromArgb(59, 119, 80);
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiar.ForeColor = SystemColors.ControlLight;
            btnCambiar.Location = new Point(136, 286);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(318, 42);
            btnCambiar.TabIndex = 3;
            btnCambiar.Text = "Cambiar contraseña";
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Click += button1_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(136, 132);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(187, 28);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo electronico:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(136, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(93, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 77, 50);
            label1.Location = new Point(230, 18);
            label1.Name = "label1";
            label1.Size = new Size(156, 47);
            label1.TabIndex = 0;
            label1.Text = "Mi perfil";
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 243, 236);
            ClientSize = new Size(663, 439);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Margin = new Padding(2);
            Name = "Usuario";
            Text = "Usuario";
            Load += Usuario_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
		private ToolStripMenuItem MenuCatalogo;
		private ToolStripMenuItem MenuAgregarPlanta;
		private ToolStripMenuItem MenuFavoritos;
		private ToolStripMenuItem MenuUsuarios;
        private Panel panel1;
        private Label label1;
        private Button btnCambiar;
        private Label lblCorreo;
        private Label lblNombre;
        private TextBox txtNueva;
        private TextBox txtActual;
        private Button btncerrarses;
    }
}