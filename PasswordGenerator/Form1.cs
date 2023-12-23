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

        private async void generatePassBT_Click(object sender, EventArgs e)
        {

            if (int.TryParse(num_tb.Text, out int chars) &&
                int.TryParse(spec_tb.Text, out int spec) &&
                spec <= chars  // <- It prevents an infinite loop.
                )
            {
                passwordTB.Text = await Task.Run(() => new Security.PasswordGenerator().Generate(chars, spec));
            }
            else
            {
                MessageBox.Show("Error!"); // There can be problems, other than just wrong input.
            }

        }
    }
}
