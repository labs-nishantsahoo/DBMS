using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "nishant" && textBox2.Text == "sahoo")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            textBox1.Text = textBox2.Text = "";
        }
    }
}
