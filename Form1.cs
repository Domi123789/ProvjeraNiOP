using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvjeraNiOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void Size_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox3.Text, out a))
            {
                this.Width += a;
                this.Height += a;
            }
        }

        private void Position_Click(object sender, EventArgs e)
        {
            int x;
            if (int.TryParse(textBox2.Text, out x))
            {
                Position.Left += x;
                textBox2.Left += x;
            }
            else
            {
                MessageBox.Show("Unesite valjan broj.");
            }
        
        }
    }
}
