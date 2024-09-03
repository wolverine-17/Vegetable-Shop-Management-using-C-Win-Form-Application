using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shop_management_project_2
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void cust_btn_Click(object sender, EventArgs e)
        {
            customer cust = new customer();
            cust.Show();

        }
        System.Data.OleDb.OleDbConnection con;
        private void mainform_Load(object sender, EventArgs e)
        {
            con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source=C:/Database5.mdb";
            con.Open();
            MessageBox.Show("database open");
            // con.Close();
            //   MessageBox.Show("database close");

        }

    }



}