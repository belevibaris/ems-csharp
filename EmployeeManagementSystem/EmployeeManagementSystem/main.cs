using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void addemployee_Click(object sender, EventArgs e)
        {
            addemployee addemployee = new addemployee(); // This is bad
            addemployee.Show();
            this.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void signout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salary_Click(object sender, EventArgs e)
        {
            salaryedit salary = new salaryedit(); // This is bad
            salary.Show();
            this.Hide();
        }
    }
}
