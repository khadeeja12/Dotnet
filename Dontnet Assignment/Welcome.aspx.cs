using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Data;

namespace Product
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal productPrice = decimal.Parse(txtProductPrice.Text);
            string imagePath = "";

            if (fuProductImage.HasFile)
            {
                string fileName = Path.GetFileName(fuProductImage.PostedFile.FileName);
                imagePath = "~/Images/" + fileName;
                fuProductImage.PostedFile.SaveAs(Server.MapPath(imagePath));
            }

            string connectionString = @"Data Source=KHADEEJA\SQLEXPRESS;Initial Catalog=root2_db;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO Products (ProductName, ProductPrice, ProductImage) VALUES (@ProductName, @ProductPrice, @ProductImage)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
            cmd.Parameters.AddWithValue("@ProductImage", imagePath);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            // Optionally clear the form
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            Response.Write("Product added successfully!");

        }




        protected void btnViewProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProducts.aspx");
        }
    }
}