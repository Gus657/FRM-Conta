namespace CapaVistaCONTA
{
    partial class mantenimiento_tipos_cuentas_contables
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mantenimiento_tipos_cuentas_contables));
			this.panel1 = new System.Windows.Forms.Panel();
			this.navegador1 = new CapaDeDiseno.Navegador();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 83);
			this.panel1.TabIndex = 1;
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.White;
			this.navegador1.Location = new System.Drawing.Point(3, 80);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(837, 642);
			this.navegador1.TabIndex = 2;
			this.navegador1.Load += new System.EventHandler(this.Navegador1_Load_1);
			// 
			// mantenimiento_tipos_cuentas_contables
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(840, 721);
			this.Controls.Add(this.navegador1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "mantenimiento_tipos_cuentas_contables";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "5111 - Tipos de Cuentas contables";
			this.Load += new System.EventHandler(this.Mantenimiento_tipos_cuentas_contables_Load);
			this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Panel panel1;
		private CapaDeDiseno.Navegador navegador1;
	}
}