/*
 * Creado por SharpDevelop.
 * Usuario: CC2-PC42
 * Fecha: 01/12/2025
 * Hora: 06:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanXChino
{
	partial class MostrarLista
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lvLista = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvLista
			// 
			this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7,
									this.columnHeader8,
									this.columnHeader9,
									this.columnHeader10,
									this.columnHeader11,
									this.columnHeader12,
									this.columnHeader13,
									this.columnHeader14,
									this.columnHeader15});
			this.lvLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvLista.Location = new System.Drawing.Point(12, 12);
			this.lvLista.Name = "lvLista";
			this.lvLista.Size = new System.Drawing.Size(1189, 440);
			this.lvLista.TabIndex = 0;
			this.lvLista.UseCompatibleStateImageBehavior = false;
			this.lvLista.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nombre";
			this.columnHeader1.Width = 73;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Apellido Materno";
			this.columnHeader2.Width = 123;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Apellido Paterno";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Fecha de nacimiento";
			this.columnHeader4.Width = 142;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Sexo:";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "CURP";
			this.columnHeader6.Width = 121;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Edad";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Ciudad";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Colonia";
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Calle";
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Numero de casa";
			this.columnHeader11.Width = 121;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Grado";
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Especialidad";
			this.columnHeader13.Width = 102;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Numero de control";
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Tipo de sangre";
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(12, 471);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(112, 45);
			this.btnRegresar.TabIndex = 1;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// MostrarLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1213, 528);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.lvLista);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MostrarLista";
			this.Text = "MostrarLista";
			this.Load += new System.EventHandler(this.MostrarListaLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvLista;
	}
}
