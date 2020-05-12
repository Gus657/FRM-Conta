﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaCONTA
{
    public partial class mantenimiento_empresas : Form
    {
        string usuario = "";        
        public mantenimiento_empresas(string usuarioActivo)
        {
            InitializeComponent();
            usuario = usuarioActivo;
            string[] alias = { "Codigo", "Nombre", "Estado" }; // Arreglo de nombres para campos
			navegador1.asignarAlias(alias); // Asignar nombres
			navegador1.asignarSalida(this); // Asignar form de salida
			Color nuevoColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); // Deficion de 
			navegador1.asignarColorFondo(nuevoColor);
			navegador1.asignarColorFuente(Color.Black);
			navegador1.asignarAyuda("1"); // asignar 1 por defecto 
										  // LOS COMBOS SE ASIGNAN SEGUN EL ORDEN EN QUE SE DECLAREN
										  //navegador1.asignarComboConTabla("tabla", "campo", 0); // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id
			navegador1.asignarTabla("empresas"); // tabla principal
			navegador1.asignarNombreForm("Empresas"); // Titulo y nombre del form
		}

        private void Navegador1_Load(object sender, EventArgs e)
        {
            
		}

		private void mantenimiento_empresas_Load(object sender, EventArgs e)
		{

		}

		private void Navegador1_Load_1(object sender, EventArgs e)
		{
			string aplicacionActiva = "5111";
			navegador1.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
			navegador1.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
			navegador1.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
		}
	}
}