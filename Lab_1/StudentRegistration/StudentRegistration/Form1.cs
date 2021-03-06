﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^[a-zA-Z ]+$") && !string.IsNullOrEmpty(comboBox1.Text) && (checkBox1.Checked || checkBox2.Checked) && radioButton1.Checked )
            {
                String profile = "";
                if (checkBox1.Checked)
                {
                    profile += "IDC | ";
                }
                if (checkBox2.Checked)
                {
                    profile += "GSMO | ";
                }
                String dob = dateTimePicker1.Value.ToShortDateString();
                MessageBox.Show("Registration details:\nName: " + textBox1.Text + "\nBranch: " + comboBox1.Text + "\nProfile: "+ profile + "\nD.O.B: " + dob, "Registration Successful!",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Invalid form details", "Registration Failed!",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            textBox1.Text = null;
            comboBox1.Text = null;
            checkBox1.Checked = checkBox2.Checked = false;
            radioButton1.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
