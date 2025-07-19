namespace ProyectoIntegrador1
{
    partial class Plantas_Interiores
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
            menu = new MenuStrip();
            MenuCatalogo = new ToolStripMenuItem();
            MenuAgregarPlanta = new ToolStripMenuItem();
            MenuFavoritos = new ToolStripMenuItem();
            MenuUsuarios = new ToolStripMenuItem();
            menu.SuspendLayout();
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
            menu.Size = new Size(693, 27);
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
            // Plantas_Interiores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(693, 433);
            Controls.Add(menu);
            Name = "Plantas_Interiores";
            Text = "Plantas_Interiores";
            WindowState = FormWindowState.Maximized;
            Load += Plantas_Interiores_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
		private ToolStripMenuItem MenuCatalogo;
		private ToolStripMenuItem MenuAgregarPlanta;
		private ToolStripMenuItem MenuFavoritos;
		private ToolStripMenuItem MenuUsuarios;
	}
}