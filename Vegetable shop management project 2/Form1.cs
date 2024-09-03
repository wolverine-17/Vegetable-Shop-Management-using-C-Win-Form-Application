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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             int  timeLeft = 10000;
            timer1.Start();
            if (timeLeft > 10000)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer1.Stop();
                LOGIN_FORM m = new LOGIN_FORM();
                m.Show();
                this.Hide();
            }


        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //this.Size = BackgroundImage.Size;
            timer1.Start();

        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
