//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using System.Data.OleDb; 

//namespace shop_management_project_2
//{
//    public partial class database : Form
//    {

//        OleDbConnection conn;
//        OleDbDataAdapter da;
//        DataSet ds;

//        public database()
//        {
//            InitializeComponent();
//        }

//        private void database_Load(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string str = "";
//// Paste your connection string that you copy from your database Properties.OleDbConnection con = new OleDbConnection(str);
//OleDbCommand cmd =new OleDbCommand("SELECT COUNT(*) FROM tablename WHERE user = '" + txt_user.text +"' AND pass = '" + txt_pass.text +"'", con);
//           con.Open();try{int i;
//i =Convert.ToInt32(cmd.ExecuteScaler());
//if (i == 1){MessageBox.Show("Success");
//}
//else{MessageBox.Show("Invalid User Name or Password");
//}
//}
//Catch (Exception ex)
//{
//MessageBox.Show(ex.Message);
//}
//Finaly
//{
//Con.Close();
//}
//        }
//    }
//}
