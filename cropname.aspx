<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="cropname.aspx.cs" Inherits="farmerapp.cropname" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container"  style="margin-top:10%;">

    <h2>Add Crop Name</h2>

    <div class="shadow rounded" style="padding:50px">
        <asp:DropDownList CssClass="form-select form-select-sm" ID="drdcategory" runat="server">
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="txtcropname" CssClass="form-control form-control-sm" placeholder="Enter Crop Name" runat="server"></asp:TextBox>
        
        <div style="margin-top:10px; text-align:right">
            <asp:Button ID="btnaddcrop" CssClass="btn btn-sm btn-success" runat="server" 
                Text="Add Crop" onclick="btnaddcrop_Click" />
        </div>


    </div>

    <div>
        <center>
            <asp:GridView AutoGenerateColumns="False" ID="gvcrops" runat="server" 
                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" GridLines="Horizontal" onrowcommand="gvcrops_RowCommand">
                <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="catname" HeaderText="Category Name" />
                <asp:BoundField DataField="cropname" HeaderText="Crop Name" />
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btndel" runat="server" CommandArgument=<%#Eval("crid")%> CssClass="btn btn-sm btn-danger" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            
            </asp:GridView>
        </center>
    </div>

    
</div>

</asp:Content>
