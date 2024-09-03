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
    public partial class customer2 : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        DataSet ds;
        String str;

        public customer2()
        {
            InitializeComponent();
        }

        private void customer2_Load(object sender, EventArgs e)
        {

            conn = new OleDbConnection();
            conn.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source=C:/Database2.mdb";
            conn.Open();
            str = "Select * from Table1";
            da = new OleDbDataAdapter(str, conn);
            ds = new DataSet();
            da.Fill(ds, "Table1");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN_FORM log1 = new LOGIN_FORM();
            log1.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}



        
    

