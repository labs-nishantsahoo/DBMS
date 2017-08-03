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
            saveToolStripMenuItem_Click(sender, e);
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
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                textBox1.Copy();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (textBox1.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        textBox1.SelectionStart = textBox1.SelectionStart + textBox1.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                textBox1.Paste();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.SelectAll();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Color = textBox1.SelectionColor;
            fd.Font = textBox1.SelectionFont;
            if(fd.ShowDialog()== DialogResult.OK)
            {
                textBox1.SelectionFont = fd.Font;
                textBox1.SelectionColor = fd.Color;
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nishantsahoo");
        } // end of the function definition
    }
}
