namespace ProyectoIntegrador1
{
    partial class Favoritos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para soporte del Diseñador - No modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            MenuCatalogo = new ToolStripMenuItem();
            MenuAgregarPlanta = new ToolStripMenuItem();
            MenuFavoritos = new ToolStripMenuItem();
            MenuUsuarios = new ToolStripMenuItem();
            menu = new MenuStrip();
            flwFavoritos = new FlowLayoutPanel();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 77, 50);
            label1.Location = new Point(379, 51);
            label1.Name = "label1";
            label1.Size = new Size(283, 37);
            label1.TabIndex = 1;
            label1.Text = "Tus Plantas Favoritas";
            label1.Click += label1_Click;
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
            // menu
            // 
            menu.Font = new Font("Sitka Small", 9.749999F);
            menu.GripStyle = ToolStripGripStyle.Visible;
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { MenuCatalogo, MenuAgregarPlanta, MenuFavoritos, MenuUsuarios });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1038, 27);
            menu.TabIndex = 41;
            menu.Text = "menuStrip2";
            // 
            // flwFavoritos
            // 
            flwFavoritos.Location = new Point(23, 101);
            flwFavoritos.Name = "flwFavoritos";
            flwFavoritos.Size = new Size(993, 574);
            flwFavoritos.TabIndex = 42;
            flwFavoritos.Paint += flwFavoritos_Paint;
            // 
            // Favoritos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 243, 236);
            ClientSize = new Size(1038, 701);
            Controls.Add(flwFavoritos);
            Controls.Add(menu);
            Controls.Add(label1);
            Name = "Favoritos";
            Text = "Favoritos";
            WindowState = FormWindowState.Maximized;
            Load += Favoritos_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem MenuCatalogo;
        private System.Windows.Forms.ToolStripMenuItem MenuAgregarPlanta;
        private System.Windows.Forms.ToolStripMenuItem MenuFavoritos;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarios;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.FlowLayoutPanel flwFavoritos;
    }
}
