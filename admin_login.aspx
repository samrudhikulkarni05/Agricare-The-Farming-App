<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_login.aspx.cs" Inherits="farmerapp.admin_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">

    <title></title>
</head>
<body style="background-image: url('http://localhost:49933/2.jpg'); background-repeat: no-repeat; background-size:cover">
    <form id="form1" runat="server">
    
    
    <div class="container shadow" style="margin-top:5%; padding:50px; background-color:rgba(255,255,255,0.8)">

        <h3>Admin Login</h3>

        <asp:TextBox placeholder="Enter User Name" ID="txtusername" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtusername" ErrorMessage="Enter User Name" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox placeholder="Enter Password" CssClass="form-control form-control-sm" TextMode="Password" ID="txtpass" runat="server"></asp:TextBox>      
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtpass" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
        
        <br/>
        <asp:Button CssClass="btn btn-outline-success btn-sm" ID="btnlogin" 
            runat="server" Text="Login" onclick="btnlogin_Click" />

        <asp:Button CssClass="btn btn-outline-danger btn-sm" ID="btncancel" CausesValidation="false" 
            runat="server" Text="Cancel" onclick="btncancel_Click"  />  

    </div>
    </form>


<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
