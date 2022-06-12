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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if(this.txtName.Text !="" )//&& txtName.Text != listBox1.Items.Contains(txtName))
            {
                listBox1.Items.Add(this.txtName.Text);
                this.txtName.Focus();
                this.txtName.Clear();

            }
            else
            {
                MessageBox.Show("Please enter Name to Add","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="")
            {
                listBox1.Items.Remove(this.txtName.Text);
                this.txtName.Clear();
                this.txtName.Focus();
            }
            if(this.listBox1.SelectedIndex>=0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                this.txtName.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
