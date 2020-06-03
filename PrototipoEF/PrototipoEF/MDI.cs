using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace PrototipoEF
{
	public partial class MDI : Form
	{
		private int childFormNumber = 0;

		public MDI()
		{
			InitializeComponent();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Ventana " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void MDI_Load(object sender, EventArgs e)
		{
			frm_login login = new frm_login();
			login.ShowDialog();
			lblusuario.Text = login.obtenerNombreUsuario();
		}

		private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_Seguridad MIDSEG = new MDI_Seguridad(lblusuario.Text);
			MIDSEG.Show();
		}

		private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Productos productos = new Productos(lblusuario.Text);
			productos.Show();
		}

		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Linea productos = new Linea(lblusuario.Text);
			productos.Show();
			
		}

		private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Marca productos = new Marca(lblusuario.Text);
			productos.Show();
		}

		private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Proveedores productos = new Proveedores(lblusuario.Text);
			productos.Show();
		}

		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Bodegas productos = new Bodegas(lblusuario.Text);
			productos.Show();
		}

		private void CreaciónDeÓrdenesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Rentas productos = new Rentas(lblusuario.Text);
			productos.Show();
		}

		private void AutorizaciónDeOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Autorizar productos = new Autorizar(lblusuario.Text);
			productos.Show();
		}

		private void ActualizaciónDeExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Actualizar productos = new Actualizar(lblusuario.Text);
			productos.Show();
		}

		private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Reportes productos = new Reportes(lblusuario.Text);
			productos.Show();
		}
	}
}
