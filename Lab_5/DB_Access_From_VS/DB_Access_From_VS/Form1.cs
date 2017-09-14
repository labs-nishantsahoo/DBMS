using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Access_From_VS
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            String oradb = "DATA SOURCE=ICTORCL;PERSIST SECURITY INFO=True;USER ID=CC3244;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "insert into DEMO3244 values('" + textBox1.Text + "'," +
                textBox2.Text + ")"; // if the type is varchar preceede the value by quote '
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Inserted!");
                conn.Close();
            }
            catch (Exception esp)
            {
                MessageBox.Show("Caught: " + esp.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect1(); 
                OracleCommand cm = new OracleCommand(); 
                cm.Connection = conn; 
                cm.CommandText = "UPDATE DEMO3244 "+ " SET NAME " + " = '" + textBox1.Text + "' WHERE ID =" +textBox2.Text ; cm.CommandType = CommandType.Text; cm.ExecuteNonQuery(); MessageBox.Show("updated!"); conn.Close(); 
            } 
            catch (Exception ew) 
            { 
                Console.WriteLine("Error: " + ew); // 
                Console.WriteLine(ew.StackTrace); 
            } 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "DELETE FROM DEMO3244 " + " WHERE id " + " = " +
                textBox2.Text;
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Deleted!");
                conn.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from DEMO3244";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "demo");
            dt = ds.Tables["demo"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox2.Text = dr["id"].ToString();
            textBox1.Text = dr["name"].ToString();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "demo";
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
