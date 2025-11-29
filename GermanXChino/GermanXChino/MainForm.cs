/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 28/11/2025
 * Hora: 06:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GermanXChino
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RegistroDeAlumnosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 f= new Form2();
			f.Show();
			this.Hide();
		}
		
		
		void CalcularPromediosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form3 f= new Form3();
			f.Show();
			this.Hide();
		}
		
		
		void OrdenadorDeNumerosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form4 f= new Form4();
			f.Show();
			this.Hide();			
		}
	}
}
