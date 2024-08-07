using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=KHADEEJA\\SQLEXPRESS;Database=StudentManagement;Trusted_Connection=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (ValidateCredentials(name, password))
            {
                ViewMarksForm viewMarksForm = new ViewMarksForm(); // Pass student ID to ViewMarksForm
                viewMarksForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool ValidateCredentials(string name, string password)
        {
            bool isValid = false;
            string query = "SELECT COUNT(*) FROM Student WHERE Name = @Name AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        int userCount = (int)command.ExecuteScalar();
                        isValid = (userCount > 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }

            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
