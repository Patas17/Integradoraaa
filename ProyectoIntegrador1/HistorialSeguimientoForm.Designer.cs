namespace ProyectoIntegrador1
{
	partial class HistorialSeguimientoForm
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
            flowRegistros = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowRegistros
            // 
            flowRegistros.AutoScroll = true;
            flowRegistros.Dock = DockStyle.Fill;
            flowRegistros.FlowDirection = FlowDirection.TopDown;
            flowRegistros.Location = new Point(0, 0);
            flowRegistros.Margin = new Padding(2);
            flowRegistros.Name = "flowRegistros";
            flowRegistros.Size = new Size(777, 430);
            flowRegistros.TabIndex = 0;
            flowRegistros.WrapContents = false;
            flowRegistros.Paint += flowRegistros_Paint;
            // 
            // HistorialSeguimientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 430);
            Controls.Add(flowRegistros);
            Margin = new Padding(2);
            Name = "HistorialSeguimientoForm";
            Text = "registros";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowRegistros;
	}
}