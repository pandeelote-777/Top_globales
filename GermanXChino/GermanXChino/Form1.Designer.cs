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
	partial class Form1
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
			this.btnRAlumnos = new System.Windows.Forms.Button();
			this.btnCalificasiones = new System.Windows.Forms.Button();
			this.btnNumeros = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LightCyan;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(495, 75);
			this.label1.TabIndex = 3;
			this.label1.Text = "BIENVENIDOS";
			// 
			// btnRAlumnos
			// 
			this.btnRAlumnos.BackColor = System.Drawing.Color.SteelBlue;
			this.btnRAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRAlumnos.Location = new System.Drawing.Point(253, 113);
			this.btnRAlumnos.Margin = new System.Windows.Forms.Padding(4);
			this.btnRAlumnos.Name = "btnRAlumnos";
			this.btnRAlumnos.Size = new System.Drawing.Size(291, 58);
			this.btnRAlumnos.TabIndex = 4;
			this.btnRAlumnos.Text = "Registro de alumnos";
			this.btnRAlumnos.UseVisualStyleBackColor = false;
			this.btnRAlumnos.Click += new System.EventHandler(this.BtnRAlumnosClick);
			// 
			// btnCalificasiones
			// 
			this.btnCalificasiones.BackColor = System.Drawing.Color.SteelBlue;
			this.btnCalificasiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalificasiones.Location = new System.Drawing.Point(253, 196);
			this.btnCalificasiones.Margin = new System.Windows.Forms.Padding(4);
			this.btnCalificasiones.Name = "btnCalificasiones";
			this.btnCalificasiones.Size = new System.Drawing.Size(291, 58);
			this.btnCalificasiones.TabIndex = 5;
			this.btnCalificasiones.Text = " Boleta de calificasiones  ";
			this.btnCalificasiones.UseVisualStyleBackColor = false;
			this.btnCalificasiones.Click += new System.EventHandler(this.BtnCalificasionesClick);
			// 
			// btnNumeros
			// 
			this.btnNumeros.BackColor = System.Drawing.Color.SteelBlue;
			this.btnNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNumeros.Location = new System.Drawing.Point(253, 284);
			this.btnNumeros.Margin = new System.Windows.Forms.Padding(4);
			this.btnNumeros.Name = "btnNumeros";
			this.btnNumeros.Size = new System.Drawing.Size(291, 58);
			this.btnNumeros.TabIndex = 6;
			this.btnNumeros.Text = "Ordenar Numeros";
			this.btnNumeros.UseVisualStyleBackColor = false;
			this.btnNumeros.Click += new System.EventHandler(this.BtnNumerosClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSalir.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(32, 327);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(204, 111);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SkyBlue;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(599, 486);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnNumeros);
			this.Controls.Add(this.btnCalificasiones);
			this.Controls.Add(this.btnRAlumnos);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnNumeros;
		private System.Windows.Forms.Button btnCalificasiones;
		private System.Windows.Forms.Button btnRAlumnos;
		private System.Windows.Forms.Label label1;
	}
}
