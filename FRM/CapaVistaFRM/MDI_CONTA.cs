﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;

namespace CapaVistaCONTA
{
    public partial class MDI_CONTA : Form
    {

		private mantenimiento_tipos_cuentas_contables frm_tipo_cuentas_contables;
		private cuentas_contables frm_cuentas_contables;
		private libro_Diario frm_libro_diario;

		sentencia sn = new sentencia();
		String usuarioActivo = "rchocm";
        public MDI_CONTA()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			usuarioActivo = Lbl_usuario.Text;

		}
        
        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========
      
     
     
		private void frm_tipo_cuentas_contables_FormClosed(Object sender, FormClosedEventArgs e)
		{ frm_tipo_cuentas_contables = null; }
		private void frm_cuentas_contables_FormClosed(Object sender, FormClosedEventArgs e)
		{ frm_cuentas_contables = null; }
		private void frm_libro_diario_FormClosed(Object sender, FormClosedEventArgs e)
		{ frm_libro_diario = null; }
		//====================Funciones de declaración de Eventos====================

		private void ConciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void BalanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void TipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ActualizaciónDePólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultarConciliaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void MovimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void RevisiónDePresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
           
        }
        
        private void MDI_CONTA_Load(object sender, EventArgs e)
        {
           
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();
            usuarioActivo = Lbl_usuario.Text; 
        } 

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }

        private void Btn_prueba_Click(object sender, EventArgs e)
        {
            //                      Usuario        Mensaje a guardar     Tabla
            sn.insertarBitacora(Lbl_usuario.Text, "Probó la Bitacora", "General");
        }

        private void MódulosToolStripMenuItem_Click(object sender, EventArgs e)
        {                        
            
        }

        private void BancosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void ChequeraToolStripMenuItem_Click(object sender, EventArgs e)
        {            
           
        }

        private void CuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {            
           
        }

        private void ClasificadorDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
          
        }

        private void MonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MonedasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

		private void LibroDiarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frm_libro_diario == null)
			{
				frm_libro_diario = new libro_Diario(usuarioActivo);
				frm_libro_diario.MdiParent = this;
				frm_libro_diario.FormClosed += new FormClosedEventHandler(frm_libro_diario_FormClosed);
				frm_libro_diario.Show();
			}
			else
			{
				frm_libro_diario.Activate();
			}
		}

		private void TiposDePólizaToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void TiposDeCuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frm_tipo_cuentas_contables == null)
			{
				frm_tipo_cuentas_contables = new mantenimiento_tipos_cuentas_contables(usuarioActivo);
				frm_tipo_cuentas_contables.MdiParent = this;
				frm_tipo_cuentas_contables.FormClosed += new FormClosedEventHandler(frm_tipo_cuentas_contables_FormClosed);
				frm_tipo_cuentas_contables.Show();
			}
			else
			{
				frm_tipo_cuentas_contables.Activate();
			}
		}

		private void CuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frm_cuentas_contables == null)
			{
				frm_cuentas_contables = new cuentas_contables(usuarioActivo);
				frm_cuentas_contables.MdiParent = this;
				frm_cuentas_contables.FormClosed += new FormClosedEventHandler(frm_cuentas_contables_FormClosed);
				frm_cuentas_contables.Show();
			}
			else
			{
				frm_cuentas_contables.Activate();
			}
		}

		private void ContabilidadToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void LibroMayorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			libro_Mayor nuevo = new libro_Mayor(usuarioActivo);
			nuevo.Show();
		}
	}
}