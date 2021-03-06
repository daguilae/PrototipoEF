﻿using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace PrototipoEF
{
	public partial class Reportes : Form
	{
		
		string usuario = "";
		conexion cn = new conexion();
		int realTotal = 0;

		public Reportes(string usuarioActivo)
		{
			InitializeComponent();
			usuario = usuarioActivo;
			

		}
		public OdbcDataAdapter LlenarTabla(string query)
		{
			
			OdbcDataAdapter dataTable = new OdbcDataAdapter(query, cn.conectar("FilmMagic"));
			return dataTable;
		}
		public void ejecutarQuery(string query)// ejecuta un query en la BD
		{
			try
			{
				OdbcCommand consulta = new OdbcCommand(query, cn.conectar("FilmMagic"));
				consulta.ExecuteNonQuery();
			}
			catch (OdbcException ex)
			{
				Console.WriteLine(ex.Errors.ToString());
				Console.WriteLine("---------------------------------------");
				Console.WriteLine(query);
			}

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void Navegador1_Load(object sender, EventArgs e)
		{
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Órdenes de Compra")
			{
				OdbcDataAdapter dt = LlenarTabla("SELECT * FROM compras_encabezado");
				DataTable table = new DataTable();
				dt.Fill(table);
				dataGridView2.DataSource = table;
				button3.Enabled = true;
			}
			else
			{
				OdbcDataAdapter dt = LlenarTabla("SELECT * FROM productos");
				DataTable table = new DataTable();
				dt.Fill(table);
				dataGridView2.DataSource = table;
				button3.Enabled = true;
			}
			

		}
		public string ObtenerPrecio(string no)
		{
			string id = "";
			OdbcCommand command = new OdbcCommand("SELECT existencia_producto FROM productos WHERE codigo_producto= " + no + ";", cn.conectar("FilmMagic"));
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{

				id = reader.GetValue(0).ToString();
			}


			return id;
		}
		public string Obtenerencabezado()
		{
			string id = "";
			OdbcCommand command = new OdbcCommand("SELECT MAX(documento_compraenca) FROM compras_encabezado;", cn.conectar("FilmMagic"));
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{

				id = reader.GetValue(0).ToString();
			}


			return id;
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			
		}

		private void Combo3_KeyDown(object sender, KeyEventArgs e)
		{

		}

		private void Combo3_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		
		}

		private void Combo3_MouseClick(object sender, MouseEventArgs e)
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
				cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
				pdftable.AddCell(cell);
			}

			foreach (DataGridViewRow row in dtg.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
				}
			}


			var savefeldialoge = new SaveFileDialog();
			savefeldialoge.FileName = name;
			savefeldialoge.DefaultExt = ".pdf";
			if (savefeldialoge.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(savefeldialoge.FileName, FileMode.Create))
				{
					Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
					PdfWriter.GetInstance(pdfdoc, stream);
					pdfdoc.Open();
					pdfdoc.Add(pdftable);
					pdfdoc.Close();
					stream.Close();
				}

			}


		}
		private void Button3_Click(object sender, EventArgs e)
		{
			exportarTabla(dataGridView2,"Reporte");
			
			MessageBox.Show("Reporte Generado");
		}
	}
}
