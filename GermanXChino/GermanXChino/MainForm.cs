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

		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			if (txtUsario.Text=="Admin" && txtContra.Text=="123") {
				Form1 f=new Form1();
				f.Show();
				Hide();
			}	
		}
	}
}
