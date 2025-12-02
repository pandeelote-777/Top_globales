/*
 * Creado por SharpDevelop.
 * Usuario: andre
 * Fecha: 28/11/2025
 * Hora: 06:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace GermanXChino
{
	partial class Form4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
			this.lblNumG = new System.Windows.Forms.Label();
			this.lblNumO = new System.Windows.Forms.Label();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNumG
			// 
			this.lblNumG.BackColor = System.Drawing.Color.CadetBlue;
			this.lblNumG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblNumG.Location = new System.Drawing.Point(47, 115);
			this.lblNumG.Name = "lblNumG";
			this.lblNumG.Size = new System.Drawing.Size(418, 52);
			this.lblNumG.TabIndex = 0;
			// 
			// lblNumO
			// 
			this.lblNumO.BackColor = System.Drawing.Color.CadetBlue;
			this.lblNumO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblNumO.Location = new System.Drawing.Point(47, 274);
			this.lblNumO.Name = "lblNumO";
			this.lblNumO.Size = new System.Drawing.Size(418, 52);
			this.lblNumO.TabIndex = 1;
			// 
			// btnGenerar
			// 
			this.btnGenerar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerar.ForeColor = System.Drawing.Color.Black;
			this.btnGenerar.Location = new System.Drawing.Point(47, 38);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(202, 53);
			this.btnGenerar.TabIndex = 2;
			this.btnGenerar.Text = "Generar numeros";
			this.btnGenerar.UseVisualStyleBackColor = false;
			this.btnGenerar.Click += new System.EventHandler(this.BtnGenerarClick);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenar.Location = new System.Drawing.Point(47, 193);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(202, 60);
			this.btnOrdenar.TabIndex = 3;
			this.btnOrdenar.Text = "Ordenar numeros";
			this.btnOrdenar.UseVisualStyleBackColor = false;
			this.btnOrdenar.Visible = false;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(459, 50);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(288, 290);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
			this.btnLimpiar.Location = new System.Drawing.Point(459, 376);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(124, 46);
			this.btnLimpiar.TabIndex = 5;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Visible = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.ForeColor = System.Drawing.Color.Black;
			this.btnRegresar.Location = new System.Drawing.Point(618, 376);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(129, 46);
			this.btnRegresar.TabIndex = 6;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(801, 489);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.lblNumO);
			this.Controls.Add(this.lblNumG);
			this.Name = "Form4";
			this.Text = "Ordenando numeros random";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.Label lblNumO;
		private System.Windows.Forms.Label lblNumG;
		
	}
}
