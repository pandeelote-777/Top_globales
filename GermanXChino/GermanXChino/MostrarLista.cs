/*
 * Creado por SharpDevelop.
 * Usuario: CC2-PC42
 * Fecha: 01/12/2025
 * Hora: 06:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanXChino
{
	/// <summary>
	/// Description of MostrarLista.
	/// </summary>
	public partial class MostrarLista : Form
	{
		public MostrarLista()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public ListViewItem Eleme=new ListViewItem();
		void MostrarListaLoad(object sender, EventArgs e)
		{
			lvLista.Items.Add(Eleme);
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
