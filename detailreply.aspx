<%@ Page Title="" Language="C#" MasterPageFile="~/expert.Master" AutoEventWireup="true"
    CodeBehind="detailreply.aspx.cs" Inherits="farmerapp.detailreply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container shadow" style="margin-top: 5%; padding: 25px">
        <div>
            <center>
                <asp:Image Height="200px" runat="server" ID="imgquery" />
                
                <br/><br/>
                <asp:TextBox placeholder="Comment Your Reply" runat="server" ID="txtreply" class="form-control form-control-sm"></asp:TextBox>
            </center>

            <div style="margin-top:20px;text-align:right">
                <asp:Button runat="server" ID="btnadd" Text="Add" class="btn btn-sm btn-success"
                    OnClick="btnadd_Click" />
                <asp:Button runat="server" ID="Button1" Text="Back" class="btn btn-sm btn-primary"
                    OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
