namespace PrototipoEF
{
	partial class Actualizar
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.combo2 = new CapaVista.Combo();
			this.button1 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.lbltotal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// combo2
			// 
			this.combo2.Location = new System.Drawing.Point(104, 99);
			this.combo2.Margin = new System.Windows.Forms.Padding(4);
			this.combo2.Name = "combo2";
			this.combo2.Size = new System.Drawing.Size(157, 26);
			this.combo2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gold;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(268, 102);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "Consultar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(89, 21);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(309, 32);
			this.label11.TabIndex = 16;
			this.label11.Text = "Consulta de Existencia";
			// 
			// lbltotal
			// 
			this.lbltotal.AutoSize = true;
			this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltotal.Location = new System.Drawing.Point(169, 177);
			this.lbltotal.Name = "lbltotal";
			this.lbltotal.Size = new System.Drawing.Size(68, 32);
			this.lbltotal.TabIndex = 18;
			this.lbltotal.Text = "0.00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(277, 177);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 32);
			this.label1.TabIndex = 19;
			this.label1.Text = "UDS";
			// 
			// Actualizar
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(503, 234);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbltotal);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.combo2);
			this.Controls.Add(this.label11);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximumSize = new System.Drawing.Size(874, 696);
			this.Name = "Actualizar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Existencias";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private CapaVista.Combo combo2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lbltotal;
		private System.Windows.Forms.Label label1;
	}
}

