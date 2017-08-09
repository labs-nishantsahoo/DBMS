using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            String user_id = username.Text;
            String pass = password.Text;
            if (user_id.Equals("nishant") && pass.Equals("cce"))
            {
                MessageBox.Show("Login Successful");
                Form2 frm = new Form2();
                frm.Show();
            }
        }

        private void forgot_Click(object sender, EventArgs e)
        {
               Form4 frm1 = new Form4();
               frm1.Show();
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
