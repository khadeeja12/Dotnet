<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProducts.aspx.cs" Inherits="Product.ViewProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Products</title>
    <style>
        table {
            width: 100%;
            border-collapse: collapse;
        }
        table, th, td {
            border: 1px solid black;
        }
        th, td {
            padding: 8px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product List</h2>
            <asp:PlaceHolder ID="phProducts" runat="server"></asp:PlaceHolder>
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price: $0.00"></asp:Label>
             <asp:Table ID="tblProducts" runat="server" BorderWidth="1" BorderColor="Black"></asp:Table>

        </div>
    </form>
</body>
</html>
