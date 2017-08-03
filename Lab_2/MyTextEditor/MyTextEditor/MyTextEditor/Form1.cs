using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            System.Drawing.Printing.PrintDocument printDoc = new System.Drawing.Printing.PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            //Call ShowDialog
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // definition of the function open
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open";
            dlg.ShowDialog();
            string fName = dlg.FileName;
            System.IO.StreamReader sr = new System.IO.StreamReader(fName);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
            this.Text = fName;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "untitled";
            this.textBox1.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "untitled")
            {
                saveAsToolStripMenuItem1_Click(sender, e);
            }
            else
            {
                string fName = this.Text;
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(textBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            if (fName != "")
            {
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(textBox1.Text);
                sw.Flush();
                sw.Close();
                this.Text = fName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        } // end of the function definition
    }
}
