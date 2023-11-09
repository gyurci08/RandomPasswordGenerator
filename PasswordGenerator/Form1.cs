using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void generatePassBT_Click(object sender, EventArgs e)
        {
            int chars, spec;

            if(int.TryParse(num_tb.Text, out chars)&& int.TryParse(spec_tb.Text, out spec))
                {
                    passwordTB.Text = Security.PasswordGenerator.Generate(chars,spec);
                }
            else
                {
                    MessageBox.Show("You should write in numbers...");
                }


            
        }

    }
}
