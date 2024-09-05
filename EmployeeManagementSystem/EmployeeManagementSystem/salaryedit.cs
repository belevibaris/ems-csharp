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
    public partial class salaryedit : Form
    {
        public salaryedit()
        {
            InitializeComponent();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            main dashboard = new main(); // This is bad
            dashboard.Show();
            this.Hide();
        }

        private void addemployee_Click(object sender, EventArgs e)
        {
            addemployee addemployee = new addemployee(); // This is bad
            addemployee.Show();
            this.Hide();
        }

        private void salaryedit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emsDatabaseDataSet2.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.emsDatabaseDataSet2.employees);

        }
    }
}
