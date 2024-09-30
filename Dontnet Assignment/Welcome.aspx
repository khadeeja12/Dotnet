<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Product.Welcome" %>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <h2>Add New Product</h2>
            
            <label for="ProductName">Product Name:</label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br /><br />

            <label for="ProductPrice">Product Price:</label>
            <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
            <br /><br />

            <label for="ProductImage">Product Image:</label>
            <asp:FileUpload ID="fuProductImage" runat="server" />
            <br /><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Add Product" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnViewProducts" runat="server" Text="View Products" OnClick="btnViewProducts_Click" />

        </div>
    </form>
</body>
</html>
