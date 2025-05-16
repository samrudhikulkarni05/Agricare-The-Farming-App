<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="expert_login.aspx.cs" Inherits="farmerapp.expert_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">



</head>
<body style="background-image: url('http://localhost:49933/1.jpg'); background-repeat: no-repeat; background-size:cover">
    <form id="form1" runat="server">
    <div style="margin-top:5%; padding:50px; background-color:rgba(255,255,255,0.8)" class="container shadow-lg rounded-2">
        
        <h2>Expert Login</h2>
        <asp:TextBox placeholder="Enter User Name" CssClass="form-control form-control-sm" ID="txtusername" runat="server"></asp:TextBox> 
        <asp:RequiredFieldValidator ControlToValidate="txtusername" ForeColor="Red"  ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter User Name"></asp:RequiredFieldValidator>

        <asp:TextBox placeholder="Enter Password" CssClass="form-control form-control-sm" ID="txtpass" TextMode="Password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ControlToValidate="txtpass" ForeColor="Red" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
        
        
        <div style="margin-top:10px; text-align:right">
            <asp:Button ID="btnlogin" runat="server" Text="Login" 
                CssClass="btn btn-sm btn-outline-success" onclick="btnlogin_Click" />
            <asp:Button ID="btncancel" CausesValidation="false" 
                CssClass="btn btn-sm btn-outline-danger" runat="server" Text="Cancel" 
                onclick="btncancel_Click" />
        </div>    
                
    </div>
    </form>


<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>

</body>
</html>
