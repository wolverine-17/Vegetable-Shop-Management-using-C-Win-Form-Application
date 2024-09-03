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
    public partial class employee : Form
    {
        String str;
        OleDbConnection conn;
        OleDbDataAdapter da;
        DataSet ds;

        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source=C:/Database2.mdb";
            conn.Open();
            str = "Select * from Table1";
            da = new OleDbDataAdapter(str, conn);
            ds = new DataSet();
            da.Fill(ds, "Table1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = ds.Tables["Table1"].Rows.Count;
            i = i + 1;
            String ty = "C";
            int sal = 0;
            int initbal = 500;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            String nmps = textBox1.Text;
            cmd.CommandText = "Insert into Table1 values(" + i + ",'" + textBox1.Text + "','" + ty + "','" + sal + "','" + initbal + "','" + nmps + "')";
            int n = cmd.ExecuteNonQuery();
            MessageBox.Show("customer added");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN_FORM log1 = new LOGIN_FORM();
            log1.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }


    }
}