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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnRegrsarClick(object sender, EventArgs e)
		{
			Form1 f =new Form1();
			f.Show();
			this.Close();
		}
		
		void BtnLimpiarTodoClick(object sender, EventArgs e)
		{
			txtApellidoM.Clear();
			txtApellidoP.Clear();
			txtCalle.Clear();
			txtCiudad.Clear();
			txtColonia.Clear();
			txtCurp.Clear();
			txtEdad.Clear();
			txtFechanac.Text="dd/mm/yyyy";
			txtNombre.Clear();
			txtNumeroC.Clear();
			txtNumeroDecon.Clear();
			cboEspeci.SelectedIndex=-1;
			cboGrado.SelectedIndex=-1;
			cboSangre.SelectedIndex=-1;
			cboSexo.SelectedIndex=-1;
		}
		
		void BtnRegistarClick(object sender, EventArgs e)
		{
			if(txtNombre.Text==""){
				MessageBox.Show("Debes de poner un nombre");
			}else{
				if (txtApellidoP.Text=="") {
					MessageBox.Show("Debes de poner el apellido paterno");
				}
				else{
					if(txtApellidoM.Text==""){
						MessageBox.Show("Debes de poner el apellido materno");
					}else{
						if(txtFechanac.Text=="dd/mm/yyyy" || txtFechanac.Text==""){
							MessageBox.Show("Debes de poner la fecha de nacimiento");
						}else{
							if(cboSexo.Text==""){
								MessageBox.Show("Debes de poner el sexo");
							}else{
								if(txtCurp.Text==""){
									MessageBox.Show("Debes de poner la CURP");
								}else{
									if(txtCiudad.Text==""){
										MessageBox.Show("Debes de poner la ciudad");
									}else{
										if(txtEdad.Text==""){
											MessageBox.Show("Debes de poner la edad");
										}else{
											if(txtColonia.Text==""){
												MessageBox.Show("Debes de poner la colonia");
											}else{
												if(txtCalle.Text==""){
													MessageBox.Show("Debes de poner la calle");
												}else{
													if (txtNumeroC.Text=="") {
														MessageBox.Show("Debes de poner el numero de la casa");
													}else{
														if (cboGrado.Text=="") {
															MessageBox.Show("Debes de poner el grado");
														}else{
															if (cboEspeci.Text=="") {
																MessageBox.Show("Debes de poner la especialidad");
															}else{
																if (txtNumeroDecon.Text=="") {
																	MessageBox.Show("Debes de poner el numero de control");
																}else{
																	if (cboSangre.Text=="") {
																		MessageBox.Show("Debes de poner el tipo de sangre");
																	}else{
																			ListViewItem fila=new ListViewItem(txtNombre.Text);
																			fila.SubItems.Add(txtApellidoP.Text);
																			fila.SubItems.Add(txtApellidoM.Text);
																			fila.SubItems.Add(txtFechanac.Text);
																			fila.SubItems.Add(cboSexo.Text);
																			fila.SubItems.Add(txtCurp.Text);
																			fila.SubItems.Add(txtEdad.Text);
																			fila.SubItems.Add(txtCiudad.Text);
																			fila.SubItems.Add(txtColonia.Text);
																			fila.SubItems.Add(txtCalle.Text);
																			fila.SubItems.Add(txtNumeroC.Text);
																			fila.SubItems.Add(cboGrado.Text);
																			fila.SubItems.Add(cboEspeci.Text);
																			fila.SubItems.Add(txtNumeroDecon.Text);
																			fila.SubItems.Add(cboSangre.Text);
			
																			MostrarLista f =new MostrarLista();
																			f.Eleme=fila;
																			f.Show();
																			BtnLimpiarTodoClick(sender, e);
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}

		}
	}
}
