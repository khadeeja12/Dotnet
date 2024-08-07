using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class AddMarksForm : Form
    {
        private string connectionString = "Server=KHADEEJA\\SQLEXPRESS;Database=StudentManagement;Trusted_Connection=True;";

        public AddMarksForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Name FROM Students";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxStudent.Items.Add(new { ID = reader["ID"], Name = reader["Name"] });
                    }
                    connection.Close();
                }
            }
            comboBoxStudent.DisplayMember = "Name";
            comboBoxStudent.ValueMember = "ID";
        }

        private void buttonAddMarks_Click(object sender, EventArgs e)
        {
            if (comboBoxStudent.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxMarks.Text) || !int.TryParse(textBoxMarks.Text, out int marks))
            {
                MessageBox.Show("Please enter a valid marks value.");
                return;
            }

            int studentID = (int)((dynamic)comboBoxStudent.SelectedItem).ID;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Marks (StudentID, Mark) VALUES (@StudentID, @Mark)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@Mark", marks);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Marks added successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void AddMarksForm_Load(object sender, EventArgs e)
        {

        }
    }
}
