namespace ProyectoIntegrador1
{
    partial class Catalogo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            catalogoToolStripMenuItem1 = new ToolStripMenuItem();
            panelPltaInto = new Panel();
            btnIrPltaInte = new Button();
            ptBPltaInte = new PictureBox();
            lblTitulo = new Label();
            panelPltaExte = new Panel();
            btnPltaExte = new Button();
            ptBPltaExte = new PictureBox();
            menu = new MenuStrip();
            MenuCatalogo = new ToolStripMenuItem();
            plantasParaExterioresToolStripMenuItem = new ToolStripMenuItem();
            plantasParaInterioresToolStripMenuItem = new ToolStripMenuItem();
            MenuAgregarPlanta = new ToolStripMenuItem();
            MenuFavoritos = new ToolStripMenuItem();
            MenuUsuarios = new ToolStripMenuItem();
            panelIntro = new Panel();
            lblIntro = new Label();
            contextMenuStrip2.SuspendLayout();
            panelPltaInto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptBPltaInte).BeginInit();
            panelPltaExte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptBPltaExte).BeginInit();
            menu.SuspendLayout();
            panelIntro.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { catalogoToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(126, 26);
            // 
            // catalogoToolStripMenuItem1
            // 
            catalogoToolStripMenuItem1.Name = "catalogoToolStripMenuItem1";
            catalogoToolStripMenuItem1.Size = new Size(125, 22);
            catalogoToolStripMenuItem1.Text = "Catalogo ";
            // 
            // panelPltaInto
            // 
            panelPltaInto.BackColor = Color.FromArgb(249, 251, 247);
            panelPltaInto.Controls.Add(ptBPltaInte);
            panelPltaInto.Location = new Point(47, 346);
            panelPltaInto.Name = "panelPltaInto";
            panelPltaInto.Size = new Size(378, 192);
            panelPltaInto.TabIndex = 4;
            panelPltaInto.Paint += panelPltaInto_Paint;
            // 
            // btnIrPltaInte
            // 
            btnIrPltaInte.BackColor = Color.FromArgb(59, 119, 80);
            btnIrPltaInte.FlatStyle = FlatStyle.Flat;
            btnIrPltaInte.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIrPltaInte.ForeColor = Color.White;
            btnIrPltaInte.Location = new Point(905, 556);
            btnIrPltaInte.Name = "btnIrPltaInte";
            btnIrPltaInte.Size = new Size(279, 40);
            btnIrPltaInte.TabIndex = 1;
            btnIrPltaInte.Text = "Plantas para Interiores";
            btnIrPltaInte.UseVisualStyleBackColor = false;
            btnIrPltaInte.Click += btnIrPltaInte_Click;
            // 
            // ptBPltaInte
            // 
            ptBPltaInte.ErrorImage = (Image)resources.GetObject("ptBPltaInte.ErrorImage");
            ptBPltaInte.Image = (Image)resources.GetObject("ptBPltaInte.Image");
            ptBPltaInte.InitialImage = (Image)resources.GetObject("ptBPltaInte.InitialImage");
            ptBPltaInte.Location = new Point(3, 3);
            ptBPltaInte.Name = "ptBPltaInte";
            ptBPltaInte.Size = new Size(372, 186);
            ptBPltaInte.SizeMode = PictureBoxSizeMode.StretchImage;
            ptBPltaInte.TabIndex = 0;
            ptBPltaInte.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Historic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(35, 77, 50);
            lblTitulo.Location = new Point(497, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(169, 47);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Catálogo";
            // 
            // panelPltaExte
            // 
            panelPltaExte.BackColor = Color.FromArgb(249, 251, 247);
            panelPltaExte.Controls.Add(ptBPltaExte);
            panelPltaExte.Location = new Point(854, 346);
            panelPltaExte.Name = "panelPltaExte";
            panelPltaExte.Size = new Size(378, 192);
            panelPltaExte.TabIndex = 5;
            // 
            // btnPltaExte
            // 
            btnPltaExte.BackColor = Color.FromArgb(59, 119, 80);
            btnPltaExte.FlatStyle = FlatStyle.Flat;
            btnPltaExte.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPltaExte.ForeColor = Color.White;
            btnPltaExte.Location = new Point(91, 556);
            btnPltaExte.Name = "btnPltaExte";
            btnPltaExte.Size = new Size(279, 40);
            btnPltaExte.TabIndex = 1;
            btnPltaExte.Text = "Plantas para Exteriores";
            btnPltaExte.UseVisualStyleBackColor = false;
            btnPltaExte.Click += btnPltaExte_Click;
            // 
            // ptBPltaExte
            // 
            ptBPltaExte.ErrorImage = (Image)resources.GetObject("ptBPltaExte.ErrorImage");
            ptBPltaExte.Image = (Image)resources.GetObject("ptBPltaExte.Image");
            ptBPltaExte.InitialImage = (Image)resources.GetObject("ptBPltaExte.InitialImage");
            ptBPltaExte.Location = new Point(3, 3);
            ptBPltaExte.Name = "ptBPltaExte";
            ptBPltaExte.Size = new Size(372, 186);
            ptBPltaExte.SizeMode = PictureBoxSizeMode.StretchImage;
            ptBPltaExte.TabIndex = 0;
            ptBPltaExte.TabStop = false;
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
            menu.TabIndex = 40;
            menu.Text = "menuStrip2";
            // 
            // MenuCatalogo
            // 
            MenuCatalogo.DropDownItems.AddRange(new ToolStripItem[] { plantasParaExterioresToolStripMenuItem, plantasParaInterioresToolStripMenuItem });
            MenuCatalogo.Name = "MenuCatalogo";
            MenuCatalogo.Size = new Size(80, 23);
            MenuCatalogo.Text = "Catálogo";
            MenuCatalogo.Click += MenuCatalogo_Click;
            MenuCatalogo.DoubleClick += MenuCatalogo_DoubleClick;
            // 
            // plantasParaExterioresToolStripMenuItem
            // 
            plantasParaExterioresToolStripMenuItem.Name = "plantasParaExterioresToolStripMenuItem";
            plantasParaExterioresToolStripMenuItem.Size = new Size(231, 24);
            plantasParaExterioresToolStripMenuItem.Text = "Plantas para exteriores";
            // 
            // plantasParaInterioresToolStripMenuItem
            // 
            plantasParaInterioresToolStripMenuItem.Name = "plantasParaInterioresToolStripMenuItem";
            plantasParaInterioresToolStripMenuItem.Size = new Size(231, 24);
            plantasParaInterioresToolStripMenuItem.Text = "Plantas para interiores";
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
            // panelIntro
            // 
            panelIntro.BackColor = Color.FromArgb(249, 251, 247);
            panelIntro.Controls.Add(lblIntro);
            panelIntro.Controls.Add(lblTitulo);
            panelIntro.Location = new Point(70, 64);
            panelIntro.Margin = new Padding(2);
            panelIntro.Name = "panelIntro";
            panelIntro.Size = new Size(1136, 260);
            panelIntro.TabIndex = 41;
            // 
            // lblIntro
            // 
            lblIntro.AutoSize = true;
            lblIntro.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntro.Location = new Point(85, 59);
            lblIntro.Margin = new Padding(2, 0, 2, 0);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(965, 182);
            lblIntro.TabIndex = 6;
            lblIntro.Text = resources.GetString("lblIntro.Text");
            lblIntro.Click += lblIntro_Click;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 243, 236);
            ClientSize = new Size(1284, 608);
            Controls.Add(btnIrPltaInte);
            Controls.Add(btnPltaExte);
            Controls.Add(panelIntro);
            Controls.Add(menu);
            Controls.Add(panelPltaExte);
            Controls.Add(panelPltaInto);
            Name = "Catalogo";
            Text = "Catálogo";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            contextMenuStrip2.ResumeLayout(false);
            panelPltaInto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptBPltaInte).EndInit();
            panelPltaExte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptBPltaExte).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panelIntro.ResumeLayout(false);
            panelIntro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem catalogoToolStripMenuItem1;
        private Panel panelPltaInto;
        private Button btnIrPltaInte;
        private PictureBox ptBPltaInte;
        private Label lblTitulo;
        private Panel panelPltaExte;
        private Button btnPltaExte;
        private PictureBox ptBPltaExte;
		private MenuStrip menu;
		private ToolStripMenuItem MenuCatalogo;
		private ToolStripMenuItem MenuAgregarPlanta;
		private ToolStripMenuItem MenuFavoritos;
		private ToolStripMenuItem MenuUsuarios;
		private ToolStripMenuItem plantasParaExterioresToolStripMenuItem;
		private ToolStripMenuItem plantasParaInterioresToolStripMenuItem;
		private Panel panelIntro;
		private Label lblIntro;
	}
}
