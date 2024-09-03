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
    public partial class LOGIN_FORM : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        DataSet ds;

        public LOGIN_FORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           conn = new OleDbConnection();
            conn.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source=C:/Database2.mdb";
            conn.Open();
            customer c1 = new customer();
            customer2 c2 = new customer2();
            employee e1 = new employee();
            int i=0;
            String str;
            if (textBox1.Text == null)
            {
                MessageBox.Show("please enter your username");
            }
            else if (textBox2.Text == null)
            {
                MessageBox.Show("please enter your password");
            }
            else
            {
                str = "Select * from Table1";
                da = new OleDbDataAdapter(str, conn);
                ds = new DataSet();
                da.Fill(ds,"Table1");
                DataRow dr;
                
                while (i < ds.Tables["Table1"].Rows.Count)
                {
                    dr = ds.Tables["Table1"].Rows[i];
                    if (textBox1.Text.ToString() == dr.ItemArray.GetValue(1).ToString())
                    {
                        if (textBox2.Text.ToString() == dr.ItemArray.GetValue(5).ToString())
                        {
                            if (dr.ItemArray.GetValue(2).ToString() == "E")
                            {
                                MessageBox.Show("employee login");
                                e1.Show();
                                this.Hide();
                                break;
                            }
                            else if (dr.ItemArray.GetValue(2).ToString() == "C")
                            {
                                MessageBox.Show("customer login");
                                c2.Show();
                                this.Hide();
                                break;
                            }
                        }
                    }
                    i++;
                }
                if (i == ds.Tables["Table1"].Rows.Count)
                {
                    MessageBox.Show("invalid username and password");
                }
            }
        }

        private void LOGIN_FORM_Load(object sender, EventArgs e)
        {

        }
        }

      
    }

