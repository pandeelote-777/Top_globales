/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 28/11/2025
 * Hora: 06:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanXChino
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnRAlumnosClick(object sender, EventArgs e)
		{
			Form2 f= new Form2();
			f.Show();
			this.Hide();			
		}
		
		void BtnCalificasionesClick(object sender, EventArgs e)
		{
			Form3 f= new Form3();
			f.Show();
			this.Hide();
		}
		
		void BtnNumerosClick(object sender, EventArgs e)
		{
			Form4 f= new Form4();
			f.Show();
			this.Hide();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
