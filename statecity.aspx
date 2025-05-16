<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="statecity.aspx.cs" Inherits="farmerapp.statecity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container" style="margin-top:10%">

    <div style="padding:50px;" class="shadow rounded">
        
       <h2>Add State</h2>


        <asp:TextBox ID="txtstate" CssClass="form-control" placeholder="Enter State Name" runat="server"></asp:TextBox>  
       
        <div style="margin-top:10px;text-align:right">
            <asp:Button ID="btnadd" CssClass="btn btn-sm btn-outline-primary" 
                runat="server" Text="Add State" onclick="btnadd_Click" />
        </div>


    </div>


    <div style="margin-top:10px">
        <center>
            <asp:GridView ID="gvstate" AutoGenerateColumns="false" runat="server" BackColor="White" 
                BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                GridLines="Horizontal" onrowcommand="gvstate_RowCommand" 
                onselectedindexchanged="gvstate_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="statename" HeaderText="State Name" />
                   
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandArgument=<%#Eval("sid")%> ID="Button1" runat="server" CssClass="btn btn-sm btn-outline-danger" Text="Delete" />
                           
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


    <div class="container"  style="margin-top:10%;">

    <h2>Add City Name</h2>



    <div class="shadow rounded" style="padding:50px">
        <asp:DropDownList CssClass="form-select form-select-sm" ID="drdstate" 
            runat="server">
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="txtcityname" CssClass="form-control form-control-sm" placeholder="Enter City Name" runat="server"></asp:TextBox>
        
        <div style="margin-top:10px; text-align:right">
            <asp:Button ID="btnaddcity" CssClass="btn btn-sm btn-success" runat="server" 
                Text="Add City" onclick="btnaddcity_Click" />

                <asp:Button ID="btncancel" CssClass="btn btn-sm btn-success" runat="server" 
                Text="Cancel" onclick="btncancelcity_Click" />
        </div>


    </div>
    <div style="margin-top:10px">
        <center>
            <asp:GridView ID="gvcity" AutoGenerateColumns="false" runat="server" BackColor="White" 
                BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                GridLines="Horizontal" onrowcommand="gvcity_RowCommand" 
                onselectedindexchanged="gvcity_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="cityname" HeaderText="City Name" />
                   
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CommandArgument=<%#Eval("cityid")%> ID="Button1" runat="server" CssClass="btn btn-sm btn-outline-danger" Text="Delete" />
                           
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

