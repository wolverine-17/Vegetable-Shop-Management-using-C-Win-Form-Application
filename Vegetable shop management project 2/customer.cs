using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace shop_management_project_2
{
    public partial class customer : Form
    {
        OleDbConnection conn;
        public customer()
        {
            InitializeComponent();

        }
        public class MyModel
        {
          
        }
           
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tname.Clear();
            TextBox4.Clear();
            TextBox3.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DataSet ds1;
        System.Data.OleDb.OleDbDataAdapter da;
        private void customer_Load(object sender, EventArgs e)
        {
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb2.Items.Remove(lb2.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null)
            {
                lb2.Items.Add(lb1.SelectedItem);
               
            }
            else
            {
                MessageBox.Show("No item selected");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = ds1.Tables["Shop2"].Rows.Count;
            i = i + 1;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            DataRow dRow = ds1.Tables["Shop2"].NewRow();
            dRow[1] = tname.Text;
            ds1.Tables["Shop2"].Rows.Add(dRow);

           

           // maxrows = maxrows + 1;

        }
    }
}
