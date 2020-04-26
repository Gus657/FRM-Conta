namespace CapaVistaCONTA
{
    partial class MDI_CONTA
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contabilidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cuentasContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiposDeCuentasContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiposDePólizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.actualizaciónDePólizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.libroMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.balanceGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.libroDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.revisiónDePresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gestiónPresupuestariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Lbl_usuario = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.contabilidadToolStripMenuItem,
            this.presupuestosToolStripMenuItem,
            this.seguridadToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// inicioToolStripMenuItem
			// 
			this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			this.inicioToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
			this.inicioToolStripMenuItem.Text = "Inicio";
			// 
			// mantenimientosToolStripMenuItem
			// 
			this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contabilidadToolStripMenuItem1});
			this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
			this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
			this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
			// 
			// contabilidadToolStripMenuItem1
			// 
			this.contabilidadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasContablesToolStripMenuItem,
            this.tiposDeCuentasContablesToolStripMenuItem,
            this.tiposDePólizaToolStripMenuItem});
			this.contabilidadToolStripMenuItem1.Name = "contabilidadToolStripMenuItem1";
			this.contabilidadToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
			this.contabilidadToolStripMenuItem1.Text = "Contabilidad";
			// 
			// cuentasContablesToolStripMenuItem
			// 
			this.cuentasContablesToolStripMenuItem.Name = "cuentasContablesToolStripMenuItem";
			this.cuentasContablesToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
			this.cuentasContablesToolStripMenuItem.Text = "Cuentas contables";
			this.cuentasContablesToolStripMenuItem.Click += new System.EventHandler(this.CuentasContablesToolStripMenuItem_Click);
			// 
			// tiposDeCuentasContablesToolStripMenuItem
			// 
			this.tiposDeCuentasContablesToolStripMenuItem.Name = "tiposDeCuentasContablesToolStripMenuItem";
			this.tiposDeCuentasContablesToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
			this.tiposDeCuentasContablesToolStripMenuItem.Text = "Tipos de cuentas contables";
			this.tiposDeCuentasContablesToolStripMenuItem.Click += new System.EventHandler(this.TiposDeCuentasContablesToolStripMenuItem_Click);
			// 
			// tiposDePólizaToolStripMenuItem
			// 
			this.tiposDePólizaToolStripMenuItem.Name = "tiposDePólizaToolStripMenuItem";
			this.tiposDePólizaToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
			this.tiposDePólizaToolStripMenuItem.Text = "Tipos de póliza";
			this.tiposDePólizaToolStripMenuItem.Click += new System.EventHandler(this.TiposDePólizaToolStripMenuItem_Click);
			// 
			// contabilidadToolStripMenuItem
			// 
			this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizaciónDePólizasToolStripMenuItem,
            this.libroDiarioToolStripMenuItem,
            this.libroMayorToolStripMenuItem,
            this.balanceGeneralToolStripMenuItem});
			this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
			this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
			this.contabilidadToolStripMenuItem.Text = "Contabilidad";
			this.contabilidadToolStripMenuItem.Click += new System.EventHandler(this.ContabilidadToolStripMenuItem_Click);
			// 
			// actualizaciónDePólizasToolStripMenuItem
			// 
			this.actualizaciónDePólizasToolStripMenuItem.Name = "actualizaciónDePólizasToolStripMenuItem";
			this.actualizaciónDePólizasToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
			this.actualizaciónDePólizasToolStripMenuItem.Text = "Actualización de Pólizas";
			this.actualizaciónDePólizasToolStripMenuItem.Click += new System.EventHandler(this.ActualizaciónDePólizasToolStripMenuItem_Click);
			// 
			// libroMayorToolStripMenuItem
			// 
			this.libroMayorToolStripMenuItem.Name = "libroMayorToolStripMenuItem";
			this.libroMayorToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
			this.libroMayorToolStripMenuItem.Text = "Libro Mayor";
			this.libroMayorToolStripMenuItem.Click += new System.EventHandler(this.LibroMayorToolStripMenuItem_Click);
			// 
			// balanceGeneralToolStripMenuItem
			// 
			this.balanceGeneralToolStripMenuItem.Name = "balanceGeneralToolStripMenuItem";
			this.balanceGeneralToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
			this.balanceGeneralToolStripMenuItem.Text = "Balance";
			this.balanceGeneralToolStripMenuItem.Click += new System.EventHandler(this.BalanceGeneralToolStripMenuItem_Click);
			// 
			// libroDiarioToolStripMenuItem
			// 
			this.libroDiarioToolStripMenuItem.Name = "libroDiarioToolStripMenuItem";
			this.libroDiarioToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
			this.libroDiarioToolStripMenuItem.Text = "Libro Diario";
			this.libroDiarioToolStripMenuItem.Click += new System.EventHandler(this.LibroDiarioToolStripMenuItem_Click);
			// 
			// presupuestosToolStripMenuItem
			// 
			this.presupuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisiónDePresupuestosToolStripMenuItem,
            this.gestiónPresupuestariaToolStripMenuItem});
			this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
			this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
			this.presupuestosToolStripMenuItem.Text = "Presupuestos";
			// 
			// revisiónDePresupuestosToolStripMenuItem
			// 
			this.revisiónDePresupuestosToolStripMenuItem.Name = "revisiónDePresupuestosToolStripMenuItem";
			this.revisiónDePresupuestosToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
			this.revisiónDePresupuestosToolStripMenuItem.Text = "Revisión de Presupuestos";
			this.revisiónDePresupuestosToolStripMenuItem.Click += new System.EventHandler(this.RevisiónDePresupuestosToolStripMenuItem_Click);
			// 
			// gestiónPresupuestariaToolStripMenuItem
			// 
			this.gestiónPresupuestariaToolStripMenuItem.Name = "gestiónPresupuestariaToolStripMenuItem";
			this.gestiónPresupuestariaToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
			this.gestiónPresupuestariaToolStripMenuItem.Text = "Gestión Presupuestaria";
			// 
			// seguridadToolStripMenuItem
			// 
			this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
			this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
			this.seguridadToolStripMenuItem.Text = "Seguridad";
			this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.SeguridadToolStripMenuItem_Click);
			// 
			// Lbl_usuario
			// 
			this.Lbl_usuario.AutoSize = true;
			this.Lbl_usuario.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_usuario.Location = new System.Drawing.Point(0, 429);
			this.Lbl_usuario.Name = "Lbl_usuario";
			this.Lbl_usuario.Size = new System.Drawing.Size(66, 21);
			this.Lbl_usuario.TabIndex = 2;
			this.Lbl_usuario.Text = "Usuario";
			this.Lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MDI_CONTA
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Lbl_usuario);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDI_CONTA";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MDI_CONTA";
			this.Load += new System.EventHandler(this.MDI_CONTA_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónDePólizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisiónDePresupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónPresupuestariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuentasContablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCuentasContablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePólizaToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem libroDiarioToolStripMenuItem;
	}
}