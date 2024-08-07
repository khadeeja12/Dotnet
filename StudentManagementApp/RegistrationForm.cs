using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagementApp
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Server=KHADEEJA\\SQLEXPRESS;Database=StudentManagement;Trusted_Connection=True;";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string department = textBoxDepartment.Text;
            string phone = textBoxPhone.Text;
            DateTime dob = dateTimePickerDOB.Value;
            string gender = radioButtonMale.Checked ? "Male" : radioButtonFemale.Checked ? "Female" : "Other";
            string password = textBoxPassword.Text;  // Get password

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Student (Name, Department, PhoneNo, DOB, Gender, Password) VALUES (@Name, @Department, @Phone, @DOB, @Gender, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@DOB", dob);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Password", password);  // Add password parameter

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Student registered successfully!");

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
