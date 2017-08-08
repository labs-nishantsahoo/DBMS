using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class form1 : Form
    {
        string firstOperand = "";
        string secondOperand = "";
        char operation = ' ';

        public form1()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "+";
            operation = '+';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "-";
            operation = '-';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "0";
            }
            else
            {
                secondOperand += "0";
            }
            displayTextBox.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "9";
            }
            else
            {
                secondOperand += "9";
            }
            displayTextBox.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double op1 = Convert.ToDouble(firstOperand);
            firstOperand = "";
            displayTextBox.Text = "";
            resultTextBox.Text = Math.Cos(op1).ToString();
            operation = ' ';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double op1 = Convert.ToDouble(firstOperand);
            displayTextBox.Text = "";
            resultTextBox.Text = Math.Sin(op1).ToString();
            operation = ' ';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "/";
            operation = '/';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double op1 = Convert.ToDouble(firstOperand);
            double op2 = Convert.ToDouble(secondOperand);
            firstOperand = "";
            secondOperand = "";
            double finalResult = 0;
            switch(operation)
            {
                case '+': finalResult = op1 + op2;      
                          break;

                case '-': finalResult = op1 - op2;
                          break;
                
                case '*': finalResult = op1 * op2;      
                          break;

                case '/': finalResult = op1 / op2;
                          break;
            }
            displayTextBox.Text = "";
            resultTextBox.Text = finalResult.ToString();
            operation = ' ';
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "1";
            }
            else
            {
                secondOperand += "1";
            }
            displayTextBox.Text += "1";
        }

        private void displayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "2";
            }
            else
            {
                secondOperand += "2";
            }
            displayTextBox.Text += "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "3";
            }
            else
            {
                secondOperand += "3";
            }
            displayTextBox.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "4";
            }
            else
            {
                secondOperand += "4";
            }
            displayTextBox.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "5";
            }
            else
            {
                secondOperand += "5";
            }
            displayTextBox.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "6";
            }
            else
            {
                secondOperand += "6";
            }
            displayTextBox.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "7";
            }
            else
            {
                secondOperand += "7";
            }
            displayTextBox.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            if (operation == ' ')
            {
                firstOperand += "8";
            }
            else
            {
                secondOperand += "8";
            }
            displayTextBox.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "*";
            operation = '*';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = String.Empty;
            resultTextBox.Text = String.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            double op1 = Convert.ToDouble(firstOperand);
            displayTextBox.Text = "";
            resultTextBox.Text = Math.Log(op1).ToString();
            operation = ' ';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double op1 = Convert.ToDouble(firstOperand);
            displayTextBox.Text = "";
            resultTextBox.Text = Math.Tan(op1).ToString();
            operation = ' ';
        }
    }
}
