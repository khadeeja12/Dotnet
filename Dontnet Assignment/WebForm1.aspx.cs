using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string connectionString = @"Data Source=KHADEEJA\SQLEXPRESS;Initial Catalog=root2_db;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password); // You should hash the password in a real-world application

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                // Login successful, redirect to the homepage or another page
                Response.Redirect("welcome.aspx");
            }
            else
            {
                // Login failed, show error message
                Response.Write("Invalid username or password");
            }

            conn.Close();

        }
    }
}