/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 28/11/2025
 * Hora: 06:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GermanXChino
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public int [] nums = new int [10];
		private readonly Random rd = new Random();
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnGenerarClick(object sender, EventArgs e)
		{
			if(lblNumG.Text==""){
			for (int i=0; i<10; i++){
				nums[i]=rd.Next(100);
			}
			string nd = "";
			for (int i=0; i<10; i++){
				nd += nums[i];
				if ( i<9 ){
					nd += "  ";
				}
			}
			lblNumG.Text=nd;
			btnOrdenar.Visible=true;
			btnLimpiar.Visible=true;
			}
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
			if(lblNumO.Text==""){
			Array.Sort(nums);
			string no = "";
			for (int i=0; i<10; i++){
				no += nums[i];
				if ( i<9 ){
					no += "  ";
				}
			}
			lblNumO.Text=no;
			}
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Hide();
			m.Show();
			Close();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			lblNumG.Text="";
			lblNumO.Text="";
			btnOrdenar.Visible=false;
			btnLimpiar.Visible=false;
		}
	}
}
