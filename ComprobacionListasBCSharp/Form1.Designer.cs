namespace ComprobacionListasBCSharp {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnDiferencias = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnGrabarNuevosDatos = new System.Windows.Forms.Button();
			this.btnAbrirLaWeb = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDiferencias
			// 
			this.btnDiferencias.AutoSize = true;
			this.btnDiferencias.Location = new System.Drawing.Point(12, 12);
			this.btnDiferencias.Name = "btnDiferencias";
			this.btnDiferencias.Size = new System.Drawing.Size(160, 23);
			this.btnDiferencias.TabIndex = 0;
			this.btnDiferencias.Text = "Mostrar Diferencias en la Web";
			this.btnDiferencias.UseVisualStyleBackColor = true;
			this.btnDiferencias.Click += new System.EventHandler(this.btnDiferencias_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(12, 42);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(720, 387);
			this.textBox1.TabIndex = 1;
			// 
			// btnGrabarNuevosDatos
			// 
			this.btnGrabarNuevosDatos.AutoSize = true;
			this.btnGrabarNuevosDatos.Location = new System.Drawing.Point(178, 13);
			this.btnGrabarNuevosDatos.Name = "btnGrabarNuevosDatos";
			this.btnGrabarNuevosDatos.Size = new System.Drawing.Size(160, 23);
			this.btnGrabarNuevosDatos.TabIndex = 2;
			this.btnGrabarNuevosDatos.Text = "Grabar Datos Actuales";
			this.btnGrabarNuevosDatos.UseVisualStyleBackColor = true;
			this.btnGrabarNuevosDatos.Click += new System.EventHandler(this.btnGrabarNuevosDatos_Click);
			// 
			// btnAbrirLaWeb
			// 
			this.btnAbrirLaWeb.AutoSize = true;
			this.btnAbrirLaWeb.Location = new System.Drawing.Point(344, 13);
			this.btnAbrirLaWeb.Name = "btnAbrirLaWeb";
			this.btnAbrirLaWeb.Size = new System.Drawing.Size(160, 23);
			this.btnAbrirLaWeb.TabIndex = 3;
			this.btnAbrirLaWeb.Text = "Abrir la web";
			this.btnAbrirLaWeb.UseVisualStyleBackColor = true;
			this.btnAbrirLaWeb.Click += new System.EventHandler(this.btnAbrirLaWeb_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 441);
			this.Controls.Add(this.btnAbrirLaWeb);
			this.Controls.Add(this.btnGrabarNuevosDatos);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnDiferencias);
			this.Name = "Form1";
			this.Text = "Comprobación listas grupo A2 Informática";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDiferencias;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnGrabarNuevosDatos;
		private System.Windows.Forms.Button btnAbrirLaWeb;
	}
}

