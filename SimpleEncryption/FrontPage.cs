using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEncryption
{
	public partial class FrontPage : Form
	{
		public FrontPage()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
	
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			string text = textBox1.Text;
			DialogResult options;
			
			if (text == "" || text == "Text here:")
			{
				options = MessageBox.Show("C'mon... It's cool =) \nWrite down something great and see the magic happening!\n\nLet's do it again? =)", 
					"It's not fair, buddy =(", MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);

				if (options == DialogResult.Cancel)
				{
					options = MessageBox.Show("Are you sure?\nI wouldn't do it if I were you! =P", "Think better about it!",
						MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

					if (options == DialogResult.Yes)
					{
						ActiveForm.Close();
					}
				}
			}
			else
			{
				textBox2.Text = MessageEncryption.Encryption(text);
			}
		}
	}
}
