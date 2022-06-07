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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Employee ID= {txtEmpNm.Text} " +
                $"\nEmployee Name= {txtEmpNm.Text} " +
                $"\nSalary= {txtEmpSal.Text} " +
                $"\nDepartment= {txtEmpDep.Text} ");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpid.Clear();
            txtEmpNm.Clear();
            txtEmpSal.Clear();
            txtEmpDep.Clear();
        }
    }
}
