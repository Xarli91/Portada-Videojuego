using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIDEOJUEGOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnableOrDisableEdit(button1_Click.ForeColor);

        }

        public void EnableOrDisableEdit(Color color)
        {
            if (color == Color.YellowGreen)
            {
                EnableEdit();
            }
            else
            {
                EnableOrDisableEdit();
            }
            }
        }
        public void EnableEdit() { 

            if (button1_Click.ForeColor == Color.Blue) {
                textBox1.Enabled = false; 
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox4.Visible= false;
                linkLabel1.Visible = true;
                button1_Click.ForeColor = Color.Blue;


            }

        }
        public void DisableEdit()
        {
            if (button1_Click.ForeColor == Color.YellowGreen)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox4.Visible = true;
                linkLabel1.Visible = true;
                button1_Click.ForeColor = Color.Blue;

            }

        
    }
}
