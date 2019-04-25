namespace SimpleEncryption
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
			this.textBox1.Location = new System.Drawing.Point(277, 167);
			this.textBox1.MaxLength = 50000;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(247, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Text here:";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Location = new System.Drawing.Point(301, 299);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 36);
			this.button1.TabIndex = 1;
			this.button1.Text = "Criptografar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.AcceptsTab = true;
			this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
			this.textBox2.Location = new System.Drawing.Point(277, 215);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(247, 20);
			this.textBox2.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
	}
}

