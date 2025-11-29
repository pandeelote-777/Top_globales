/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 28/11/2025
 * Hora: 06:45 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanXChino
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFechaNac = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboSexo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCurp = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNumDSe = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNumDCon = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cboTipodeSan = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cboSpeci = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cboGrado = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiarTodo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombres:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(79, 37);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(117, 22);
			this.txtNombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellidos:";
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(79, 76);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(117, 22);
			this.txtApellidos.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(211, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fecha de nacimiento:";
			// 
			// txtFechaNac
			// 
			this.txtFechaNac.Location = new System.Drawing.Point(357, 38);
			this.txtFechaNac.Name = "txtFechaNac";
			this.txtFechaNac.Size = new System.Drawing.Size(100, 22);
			this.txtFechaNac.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(211, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Sexo:";
			// 
			// cboSexo
			// 
			this.cboSexo.FormattingEnabled = true;
			this.cboSexo.Items.AddRange(new object[] {
									"F",
									"M"});
			this.cboSexo.Location = new System.Drawing.Point(253, 75);
			this.cboSexo.Name = "cboSexo";
			this.cboSexo.Size = new System.Drawing.Size(40, 24);
			this.cboSexo.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(307, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "CURP:";
			// 
			// txtCurp
			// 
			this.txtCurp.Location = new System.Drawing.Point(357, 75);
			this.txtCurp.Name = "txtCurp";
			this.txtCurp.Size = new System.Drawing.Size(167, 22);
			this.txtCurp.TabIndex = 9;
			this.txtCurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(169, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Numero de seguro social:";
			// 
			// txtNumDSe
			// 
			this.txtNumDSe.Location = new System.Drawing.Point(176, 120);
			this.txtNumDSe.Name = "txtNumDSe";
			this.txtNumDSe.Size = new System.Drawing.Size(141, 22);
			this.txtNumDSe.TabIndex = 11;
			this.txtNumDSe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(23, 153);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Numero de control:";
			// 
			// txtNumDCon
			// 
			this.txtNumDCon.Location = new System.Drawing.Point(151, 153);
			this.txtNumDCon.Name = "txtNumDCon";
			this.txtNumDCon.Size = new System.Drawing.Size(166, 22);
			this.txtNumDCon.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(323, 119);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(111, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Tipo de sangre:";
			// 
			// cboTipodeSan
			// 
			this.cboTipodeSan.FormattingEnabled = true;
			this.cboTipodeSan.Items.AddRange(new object[] {
									"A+",
									"A-",
									"B+",
									"B-",
									"AB+",
									"AB-",
									"O+",
									"O-"});
			this.cboTipodeSan.Location = new System.Drawing.Point(430, 116);
			this.cboTipodeSan.Name = "cboTipodeSan";
			this.cboTipodeSan.Size = new System.Drawing.Size(79, 24);
			this.cboTipodeSan.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(53, 187);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Especialidad:";
			// 
			// cboSpeci
			// 
			this.cboSpeci.FormattingEnabled = true;
			this.cboSpeci.Items.AddRange(new object[] {
									"Programacion",
									"Cirberseguridad",
									"Alimentos",
									"Contabilidad",
									"Mecanica",
									"Soporte",
									"Ofimatica",
									"Administracion"});
			this.cboSpeci.Location = new System.Drawing.Point(151, 184);
			this.cboSpeci.Name = "cboSpeci";
			this.cboSpeci.Size = new System.Drawing.Size(164, 24);
			this.cboSpeci.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(375, 152);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Grado:";
			// 
			// cboGrado
			// 
			this.cboGrado.FormattingEnabled = true;
			this.cboGrado.Items.AddRange(new object[] {
									"1ro",
									"2do",
									"3ro",
									"4ro",
									"5to",
									"6to"});
			this.cboGrado.Location = new System.Drawing.Point(430, 152);
			this.cboGrado.Name = "cboGrado";
			this.cboGrado.Size = new System.Drawing.Size(79, 24);
			this.cboGrado.TabIndex = 19;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(138, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(226, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Datos del alumno";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(14, 225);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 23);
			this.label12.TabIndex = 21;
			this.label12.Text = "Calle: ";
			// 
			// txtCalle
			// 
			this.txtCalle.Location = new System.Drawing.Point(61, 225);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(122, 22);
			this.txtCalle.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(198, 227);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(63, 23);
			this.label13.TabIndex = 23;
			this.label13.Text = "Numero:";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(261, 227);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(56, 22);
			this.txtNumero.TabIndex = 24;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(331, 227);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 25;
			this.label14.Text = "Colonia:";
			// 
			// txtColonia
			// 
			this.txtColonia.Location = new System.Drawing.Point(392, 225);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(117, 22);
			this.txtColonia.TabIndex = 26;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(23, 266);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(80, 37);
			this.btnRegresar.TabIndex = 27;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(392, 266);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(122, 34);
			this.btnGuardar.TabIndex = 28;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiarTodo
			// 
			this.btnLimpiarTodo.Location = new System.Drawing.Point(264, 266);
			this.btnLimpiarTodo.Name = "btnLimpiarTodo";
			this.btnLimpiarTodo.Size = new System.Drawing.Size(100, 34);
			this.btnLimpiarTodo.TabIndex = 29;
			this.btnLimpiarTodo.Text = "Limpiar todo";
			this.btnLimpiarTodo.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 315);
			this.Controls.Add(this.btnLimpiarTodo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.txtColonia);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtCalle);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cboGrado);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cboSpeci);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cboTipodeSan);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtNumDCon);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtNumDSe);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCurp);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboSexo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFechaNac);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtApellidos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form2";
			this.Text = "Registro de alumnos";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnLimpiarTodo;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cboGrado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cboSpeci;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cboTipodeSan;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNumDCon;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNumDSe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCurp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboSexo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFechaNac;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
	}
}
