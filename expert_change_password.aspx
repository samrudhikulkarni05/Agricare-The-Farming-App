<%@ Page Title="" Language="C#" MasterPageFile="~/expert.Master" AutoEventWireup="true" CodeBehind="expert_change_password.aspx.cs" Inherits="farmerapp.expert_change_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div style="margin-top:5%; padding:50px" class="shadow container rounded-3">
<h2>Expert Change Password</h2>
<asp:TextBox placeholder="Enter Your Password" ID="txtpass" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtpass" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox placeholder="Enter  New Password" CssClass="form-control form-control-sm" TextMode="Password" ID="txtnewpass" runat="server"></asp:TextBox>      
        
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtnewpass" ErrorMessage="Enter New Password" ForeColor="Red"></asp:RequiredFieldValidator>
        

        <asp:TextBox placeholder="Confirm Password" CssClass="form-control form-control-sm" TextMode="Password" ID="txtnewpass2" runat="server"></asp:TextBox> 

        <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToCompare="txtnewpass" ControlToValidate="txtnewpass2" 
        ErrorMessage="Both Password Must Match" ForeColor="Red"></asp:CompareValidator>
    <br />
    <br />
    <br />
         <asp:Button CssClass="btn btn-outline-success btn-sm" ID="btnchng" 
            runat="server" Text="Change" onclick="btnchng_Click1"  />

            
             <asp:Button CssClass="btn btn-outline-success btn-sm" ID="btncancel" 
            runat="server" Text="Cancel" CausesValidation="False"  />
            </div>

</asp:Content>
