using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class addemployee : Form
    {
        public addemployee()
        {
            InitializeComponent();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            main dashboard = new main(); // This is bad
            dashboard.Show();
            this.Hide();
        }

        private void addemployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emsDatabaseDataSet1.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.emsDatabaseDataSet1.employees);
            LoadData();
        }

        private void LoadData()
        {
            try {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\emsDatabase.mdf;Integrated Security=True";
                string query = "SELECT * FROM employees";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { // Connection string to your SQL Server database
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\emsDatabase.mdf;Integrated Security=True";

                // SQL query to insert data into the employees table
                string query = "INSERT INTO employees (employee_name, employee_surname, employee_salary, employee_position, employee_gender, employee_email, employee_tel_no, employee_year_of_birth) " +
                               "VALUES (@Name, @Surname, @Salary, @Position, @Gender, @Email, @TelNo, @YearOfBirth)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        command.Parameters.AddWithValue("@Salary", decimal.Parse(txtSalary.Text));
                        command.Parameters.AddWithValue("@Position", cmbPosition.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@TelNo", txtTelNo.Text);
                        command.Parameters.AddWithValue("@YearOfBirth", int.Parse(txtYearOfBirth.Text));

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Employee added successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

                // Refresh the DataGridView to show the new data
                LoadData();
            }
            catch { MessageBox.Show("Something Went Wrong!"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\emsDatabase.mdf;Integrated Security=True";
                string query = "SELECT * FROM employees WHERE employee_name LIKE @Name";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", "%" + txtSearchName.Text + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch { MessageBox.Show("Please Type In A Valid Name (Example: Jon)"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\emsDatabase.mdf;Integrated Security=True";
                string query = "SELECT * FROM employees WHERE employee_id = @ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", int.Parse(txtSearchID.Text));

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch { MessageBox.Show("Please Type In A Valid ID (Example: 1)"); }
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

