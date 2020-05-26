using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaModeloCONTA;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CapaVistaCONTA
{
	public partial class actualizarPolizas : Form
	{
		PolizasDetalles Libro = new PolizasDetalles();
		sentencia sn = new sentencia();
		string user = "";
		string idLibro = "";
		public actualizarPolizas(string usuario)
		{
			user = usuario;
			InitializeComponent();
			
			llenarLibros();
			tablaMovimientos();
			
		}

		void llenarLibros() {
			// 
			//// LLENAR TABLA DE LIBROS EN INGRESO
			OdbcDataAdapter dt = Libro.llenarPolizasDetalles();
			DataTable table = new DataTable();
			dt.Fill(table);
			Dtgv_EncaLibro.DataSource = table;

			OdbcDataAdapter dt2 = Libro.llenarPolizasDetalles2();
			DataTable table2 = new DataTable();
			dt2.Fill(table2);
			Dtgv_EncaPoliza.DataSource = table2;
		}
		
		void tablaMovimientos() {

			
		}
		
		
		private void actualizarPolizas_Load(object sender, EventArgs e)
		{
			
			Tbc_LibroDiario.Appearance = TabAppearance.FlatButtons;
			Tbc_LibroDiario.ItemSize = new Size(0, 1);
			Tbc_LibroDiario.SizeMode = TabSizeMode.Fixed;
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void GroupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void Label10_Click(object sender, EventArgs e)
		{

		}

		private void Cmb_Empresa_Crear_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			
			
		}

		private void Dtg_LibroDiario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void Btn_actualizar_Click(object sender, EventArgs e)
		{
			
		}

		private void Btn_Partidas_Click(object sender, EventArgs e)
		{
			

		}

		private void Btn_Guardar_partia_Click(object sender, EventArgs e)
		{
			
		}

		private void Btn_quiat_Click(object sender, EventArgs e)
		{
			Dtgv_DetaPoliza.Rows.RemoveAt(Dtgv_DetaPoliza.CurrentRow.Index);
		}

		private void Tbc_LibroDiario_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Dtg_Partidas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			
			
			
		}

		void exportarTabla(DataGridView dtg, string name)
		{
			BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
			PdfPTable pdftable = new PdfPTable(dtg.Columns.Count);
			pdftable.DefaultCell.Padding = 3;
			pdftable.WidthPercentage = 100;
			pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
			pdftable.DefaultCell.BorderWidth = 1;

			iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
			foreach (DataGridViewColumn col in dtg.Columns)
			{
				PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
				cell.BackgroundColor = new iTextSharp.text.BaseColor(240,240,240);
				pdftable.AddCell(cell);
			}

			foreach (DataGridViewRow row in dtg.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					pdftable.AddCell(new Phrase(cell.Value.ToString(),text));
				}
			}


			var savefeldialoge = new SaveFileDialog();
			savefeldialoge.FileName = name;
			savefeldialoge.DefaultExt = ".pdf";
			if (savefeldialoge.ShowDialog()==DialogResult.OK)
			{
				using (FileStream stream = new FileStream(savefeldialoge.FileName,FileMode.Create))
				{
					Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
					PdfWriter.GetInstance(pdfdoc,stream);
					pdfdoc.Open();
					pdfdoc.Add(pdftable);
					pdfdoc.Close();
					stream.Close();
				}

			}


		}
		private void Button2_Click(object sender, EventArgs e)
		{
			
		}

		private void Dtg_LibroDiario_MouseEnter(object sender, EventArgs e)
		{
			
		}

		private void Dtg_Movimientos_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void Dtg_Movimientos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{

		}

		
		

		private void Dtg_Movimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

			
			
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			Tbc_LibroDiario.SelectedIndex = 0;
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			string partida = Libro.IdPartida(idLibro);
		
			Libro.crearPartida(partida, idLibro, Dtgv_EncaPoliza.CurrentRow.Cells[2].Value.ToString()+" "+ partida, Dtgv_EncaPoliza.CurrentRow.Cells[1].Value.ToString());
			foreach (DataGridViewRow row in Dtgv_DetaPoliza.Rows)
			{
				
					Libro.crearDetallePolizasDetalles(row.Index.ToString(), idLibro, partida, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
				
			}
			
			llenarLibros();
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			Tbc_LibroDiario.SelectedIndex = 0;
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			Tbc_LibroDiario.SelectedIndex = 1;
		}

		private void PictureBox2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"Ayudas\ProcesoDiario.chm");
		}

		private void Dtg_Movimientos_MouseEnter(object sender, EventArgs e)
		{
			
		}

		private void Dtg_Movimientos_MouseMove(object sender, MouseEventArgs e)
		{
			
		}

		private void Dtgv_EncaPoliza_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string idPoliza="";
			idPoliza = Dtgv_EncaPoliza.CurrentRow.Cells[0].Value.ToString();
			OdbcDataAdapter dt2 = Libro.llenarPolizasDetalles3(idPoliza);
			DataTable table2 = new DataTable();
			dt2.Fill(table2);
			Dtgv_DetaPoliza.DataSource = table2;
		}

		private void Dtgv_EncaLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			idLibro = Dtgv_EncaLibro.CurrentRow.Cells[0].Value.ToString();
			OdbcDataAdapter dt = Libro.llenarPartidas(idLibro);
			DataTable table = new DataTable();
			dt.Fill(table);
			Dtgv_DetaLibro.Rows.Clear();
			foreach (DataRow row in table.Rows)
			{

				Dtgv_DetaLibro.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
			}
			foreach (DataGridViewRow row in Dtgv_DetaLibro.Rows)
			{
				if (row.Cells[0].Value.ToString() != "")
				{
					row.DefaultCellStyle.BackColor = Color.Firebrick;
					row.DefaultCellStyle.ForeColor = Color.White;

				}
			}
		}
	}
}
