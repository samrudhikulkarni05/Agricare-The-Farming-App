<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="cropcategory.aspx.cs" Inherits="farmerapp.cropcategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="margin-top:10%">

    <div style="padding:50px;" class="shadow rounded">
        
       <h2>Add Crop Category</h2>


        <asp:TextBox ID="txtcategory" CssClass="form-control" placeholder="Enter Category Name" runat="server"></asp:TextBox>  
       
        <div style="margin-top:10px;text-align:right">
            <asp:Button ID="btnadd" CssClass="btn btn-sm btn-outline-primary" 
                runat="server" Text="Add Category" onclick="btnadd_Click" />
        </div>


    </div>


    <div style="margin-top:10px">
        <center>
            <asp:GridView ID="gvcategory" AutoGenerateColumns="false" runat="server" BackColor="White" 
                BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                GridLines="Horizontal" onrowcommand="gvcategory_RowCommand">
                <Columns>
                    <asp:BoundField DataField="catname" HeaderText="Crop Category Name" />
                   
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandArgument=<%#Eval("catid")%> ID="Button1" runat="server" CssClass="btn btn-sm btn-outline-danger" Text="Delete" />
                           
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>


                <AlternatingRowStyle BackColor="#F7F7F7" />
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
