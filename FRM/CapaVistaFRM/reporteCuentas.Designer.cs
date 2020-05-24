namespace CapaVistaCONTA
{
    partial class reporteCuentas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporteCuentas));
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.CuentasContables1 = new CapaVistaFRM.CuentasContables();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = 0;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = this.CuentasContables1;
			this.crystalReportViewer1.Size = new System.Drawing.Size(898, 821);
			this.crystalReportViewer1.TabIndex = 0;
			// 
			// reporteCuentas
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(898, 821);
			this.Controls.Add(this.crystalReportViewer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "reporteCuentas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reporte Cuentas";
			this.Load += new System.EventHandler(this.reporteCuentas_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private CapaVistaFRM.CuentasContables CuentasContables1;
	}
}