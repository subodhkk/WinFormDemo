using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text =="admin" && txtPassword.Text =="123")
            {
                MessageBox.Show("Login Successfull");
            }
            else
                MessageBox.Show("Login Fail");

            if(txtUserName.Text == "guest" && txtPassword.Text == "0101")
            {
                MessageBox.Show("Welcome Guest");
            }
            else
                MessageBox.Show("Enter valid Password/ Name");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
