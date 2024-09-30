using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product
{
    public partial class ViewProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductData();
            }
        }

        private void BindProductData()
        {
            string connectionString = @"Data Source=KHADEEJA\SQLEXPRESS;Initial Catalog=root2_db;Integrated Security=True;Encrypt=False";
            string query = "SELECT ProductName, ProductPrice, ProductImage FROM Products";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Create table header
                        TableHeaderRow header = new TableHeaderRow();
                        header.Cells.Add(new TableHeaderCell { Text = "Product Name" });
                        header.Cells.Add(new TableHeaderCell { Text = "Product Price" });
                        header.Cells.Add(new TableHeaderCell { Text = "Product Image" });
                        header.Cells.Add(new TableHeaderCell { Text = "Add to Cart" });
                        tblProducts.Rows.Add(header);

                        // Add rows dynamically
                        foreach (DataRow row in dt.Rows)
                        {
                            TableRow tableRow = new TableRow();

                            // Product Name
                            TableCell nameCell = new TableCell { Text = row["ProductName"].ToString() };
                            tableRow.Cells.Add(nameCell);

                            // Product Price
                            // Format the price as currency
                            float productPrice = Convert.ToSingle(row["ProductPrice"]);
                            TableCell priceCell = new TableCell { Text = string.Format("{0:C}", productPrice) };

                            tableRow.Cells.Add(priceCell);

                            // Product Image
                            TableCell imageCell = new TableCell();
                            string resolvedImagePath = ResolveUrl(row["ProductImage"].ToString());
                            imageCell.Text = $"<img src='{resolvedImagePath}' alt='Product Image' style='width:100px;height:auto;'/>";
                            tableRow.Cells.Add(imageCell);

                            // Add to Cart Button
                            TableCell buttonCell = new TableCell();
                            Button addToCartButton = new Button
                            {
                                Text = "Add to Cart",
                                CommandArgument = row["ProductName"] + "," + row["ProductPrice"],
                                ID = "btnAddToCart_" + row["ProductName"].ToString()
                            };
                            addToCartButton.Click += new EventHandler(btnAddToCart_Click);
                            buttonCell.Controls.Add(addToCartButton);
                            tableRow.Cells.Add(buttonCell);

                            // Add the row to the table
                            tblProducts.Rows.Add(tableRow);
                        }
                    }
                }
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] arguments = btn.CommandArgument.Split(',');

            if (arguments.Length == 2)
            {
                string productName = arguments[0];
                float productPrice;

                // Validate and parse the product price
                if (float.TryParse(arguments[1], out productPrice))
                {
                    // Insert the product into the cart table
                    AddToCart(productName, productPrice);

                    // Update total price
                    UpdateTotalPrice();
                }
                else
                {
                    // Handle parsing error
                    Console.WriteLine("Error: Invalid product price format.");
                }
            }
            else
            {
                // Handle incorrect argument format
                Console.WriteLine("Error: Invalid command argument format.");
            }
        }


        private float GetProductPrice(string productName)
        {
            string connectionString = @"Data Source=KHADEEJA\SQLEXPRESS;Initial Catalog=root2_db;Integrated Security=True;Encrypt=False";
            string query = "SELECT ProductPrice FROM Products WHERE ProductName = @ProductName";
            float productPrice = -1; // Default value indicating not found

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            productPrice = Convert.ToSingle(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it or display it)
                Console.WriteLine("Error: " + ex.Message);
            }
            return productPrice;
        }


        private void AddToCart(string productName, float productPrice)
        {
            string connectionString = @"Data Source=KHADEEJA\SQLEXPRESS;Initial Catalog=root2_db;Integrated Security=True;Encrypt=False";
            string query = "INSERT INTO Cart (ProductName, ProductPrice) VALUES (@ProductName, @ProductPrice)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateTotalPrice()
        {
            float totalPrice = CalculateTotalPrice();
            lblTotalPrice.Text = $"Total Price: {totalPrice:C}";


        }

        private float CalculateTotalPrice()
        {
            float totalPrice = 0;
            string connectionString = @"Data Source=KHADEEJA\SQLEXPRESS;Initial Catalog=root2_db;Integrated Security=True;Encrypt=False";
            string query = "SELECT SUM(ProductPrice) FROM Cart";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalPrice = Convert.ToSingle(result);
                    }
                }
            }
            return totalPrice;
        }


    }
}
