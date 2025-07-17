namespace ProyectoIntegrador1
{
	partial class Inicio_de_sesion
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
            lbl_InicioSesion = new Label();
            txtCorreo = new TextBox();
            txtContra = new TextBox();
            btnIniciar = new Button();
            tbCuenta = new TabControl();
            Registrarse = new TabPage();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtName = new TextBox();
            lblRegistro = new Label();
            btnRegistrar = new Button();
            lblPass = new Label();
            Iniciar_Sesion = new TabPage();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            tbCuenta.SuspendLayout();
            Registrarse.SuspendLayout();
            Iniciar_Sesion.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_InicioSesion
            // 
            lbl_InicioSesion.AutoSize = true;
            lbl_InicioSesion.Font = new Font("Times New Roman", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_InicioSesion.Location = new Point(187, 29);
            lbl_InicioSesion.Margin = new Padding(2, 0, 2, 0);
            lbl_InicioSesion.Name = "lbl_InicioSesion";
            lbl_InicioSesion.Size = new Size(256, 43);
            lbl_InicioSesion.TabIndex = 0;
            lbl_InicioSesion.Text = "Inicio de sesion";
            lbl_InicioSesion.Click += lbl_InicioSesion_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(173, 125);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(292, 35);
            txtCorreo.TabIndex = 3;
            txtCorreo.Text = "Correo elctronico";
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.Location = new Point(173, 188);
            txtContra.Margin = new Padding(2);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(292, 35);
            txtContra.TabIndex = 4;
            txtContra.Text = "Contraseña";
            txtContra.TextChanged += txtContra_TextChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(173, 256);
            btnIniciar.Margin = new Padding(2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(292, 37);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // tbCuenta
            // 
            tbCuenta.Controls.Add(Registrarse);
            tbCuenta.Controls.Add(Iniciar_Sesion);
            tbCuenta.Location = new Point(32, 1);
            tbCuenta.Margin = new Padding(2);
            tbCuenta.Name = "tbCuenta";
            tbCuenta.SelectedIndex = 0;
            tbCuenta.Size = new Size(605, 418);
            tbCuenta.TabIndex = 6;
            // 
            // Registrarse
            // 
            Registrarse.BackColor = Color.FromArgb(249, 251, 247);
            Registrarse.Controls.Add(linkLabel1);
            Registrarse.Controls.Add(label1);
            Registrarse.Controls.Add(txtEmail);
            Registrarse.Controls.Add(txtPass);
            Registrarse.Controls.Add(txtName);
            Registrarse.Controls.Add(lblRegistro);
            Registrarse.Controls.Add(btnRegistrar);
            Registrarse.Controls.Add(lblPass);
            Registrarse.Location = new Point(4, 24);
            Registrarse.Margin = new Padding(2);
            Registrarse.Name = "Registrarse";
            Registrarse.Padding = new Padding(2);
            Registrarse.Size = new Size(597, 390);
            Registrarse.TabIndex = 0;
            Registrarse.Text = "Registrarse";
            Registrarse.Click += Registrarse_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(275, 310);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Inicia sesion aquí";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 309);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 15;
            label1.Text = "¿Ya tienes una cuenta?";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(142, 144);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(367, 39);
            txtEmail.TabIndex = 13;
            txtEmail.Text = "Correo electronico";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(142, 204);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(367, 39);
            txtPass.TabIndex = 10;
            txtPass.Text = "Contraseña";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(142, 89);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(367, 39);
            txtName.TabIndex = 9;
            txtName.Text = "Nombre Completo";
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistro.ForeColor = Color.FromArgb(35, 77, 50);
            lblRegistro.Location = new Point(105, 13);
            lblRegistro.Margin = new Padding(2, 0, 2, 0);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(447, 50);
            lblRegistro.TabIndex = 6;
            lblRegistro.Text = "Bienvenido a Flower Grow";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(59, 119, 80);
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(59, 119, 80);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLight;
            btnRegistrar.Location = new Point(142, 255);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(367, 42);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar cuenta";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(19, 208);
            lblPass.Margin = new Padding(2, 0, 2, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(0, 31);
            lblPass.TabIndex = 8;
            // 
            // Iniciar_Sesion
            // 
            Iniciar_Sesion.Controls.Add(linkLabel2);
            Iniciar_Sesion.Controls.Add(label2);
            Iniciar_Sesion.Controls.Add(txtContra);
            Iniciar_Sesion.Controls.Add(txtCorreo);
            Iniciar_Sesion.Controls.Add(btnIniciar);
            Iniciar_Sesion.Controls.Add(lbl_InicioSesion);
            Iniciar_Sesion.Location = new Point(4, 24);
            Iniciar_Sesion.Margin = new Padding(2);
            Iniciar_Sesion.Name = "Iniciar_Sesion";
            Iniciar_Sesion.Padding = new Padding(2);
            Iniciar_Sesion.Size = new Size(597, 390);
            Iniciar_Sesion.TabIndex = 1;
            Iniciar_Sesion.Text = "Inicio de sesion";
            Iniciar_Sesion.UseVisualStyleBackColor = true;
            Iniciar_Sesion.Click += Iniciar_Sesion_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(308, 313);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(80, 15);
            linkLabel2.TabIndex = 17;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Crea una aquí";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 313);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 16;
            label2.Text = "¿No tienes una cuenta?";
            // 
            // Inicio_de_sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 243, 236);
            ClientSize = new Size(663, 439);
            Controls.Add(tbCuenta);
            Margin = new Padding(2);
            Name = "Inicio_de_sesion";
            Text = "Inicio_de_sesion";
            tbCuenta.ResumeLayout(false);
            Registrarse.ResumeLayout(false);
            Registrarse.PerformLayout();
            Iniciar_Sesion.ResumeLayout(false);
            Iniciar_Sesion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_InicioSesion;
		private TextBox txtCorreo;
		private TextBox txtContra;
		private Button btnIniciar;
		private TabControl tbCuenta;
		private TabPage Registrarse;
		private TabPage Iniciar_Sesion;
		private TextBox txtEmail;
		private TextBox txtPass;
		private TextBox txtName;
		private Label lblRegistro;
		private Button btnRegistrar;
		private Label lblPass;
        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label2;
    }
}