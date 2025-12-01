/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 28/11/2025
 * Hora: 06:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanXChino
{
	partial class MainForm
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
			this.SuspendLayout();
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 253);
			this.Name = "MainForm";
			this.Text = "GermanXChino";
			this.ResumeLayout(false);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.registroDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calcularPromediosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ordenadorDeNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.registroDeAlumnosToolStripMenuItem,
									this.calcularPromediosToolStripMenuItem,
									this.ordenadorDeNumerosToolStripMenuItem,
									this.sALIRToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(517, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// registroDeAlumnosToolStripMenuItem
			// 
			this.registroDeAlumnosToolStripMenuItem.Name = "registroDeAlumnosToolStripMenuItem";
			this.registroDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
			this.registroDeAlumnosToolStripMenuItem.Text = "C) Registro de alumnos";
			this.registroDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeAlumnosToolStripMenuItemClick);
			// 
			// calcularPromediosToolStripMenuItem
			// 
			this.calcularPromediosToolStripMenuItem.Name = "calcularPromediosToolStripMenuItem";
			this.calcularPromediosToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
			this.calcularPromediosToolStripMenuItem.Text = "D) Calcular promedios";
			this.calcularPromediosToolStripMenuItem.Click += new System.EventHandler(this.CalcularPromediosToolStripMenuItemClick);
			// 
			// ordenadorDeNumerosToolStripMenuItem
			// 
			this.ordenadorDeNumerosToolStripMenuItem.Name = "ordenadorDeNumerosToolStripMenuItem";
			this.ordenadorDeNumerosToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
			this.ordenadorDeNumerosToolStripMenuItem.Text = "E) Ordenador de numeros";
			this.ordenadorDeNumerosToolStripMenuItem.Click += new System.EventHandler(this.OrdenadorDeNumerosToolStripMenuItemClick);
			// 
			// sALIRToolStripMenuItem
			// 
			this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
			this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.sALIRToolStripMenuItem.Text = "SALIR";
			this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.SALIRToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(517, 89);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "GermanXChino";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ordenadorDeNumerosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calcularPromediosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroDeAlumnosToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
