<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="farmerlist.aspx.cs" Inherits="farmerapp.farmerlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="container" style="margin-top:5%;padding:25px">

<div class="row">
    
    <div class="col-sm-8">
        <asp:TextBox ID="txtsearch" class="form-control form-control-sm" placeholder="Farmer Name/City/State" runat="server"></asp:TextBox>
    </div>

    <div class="col-sm-4">
        <asp:Button ID="btnsearch" class="btn btn-sm btn-success" runat="server" 
            Text="Search" onclick="btnsearch_Click" />
    </div>
        

</div>


<div class="shadow rounded" style="margin-top:3%;  padding:25px">

<center>

    <asp:GridView style="width:100%;" runat="server" ID="gvfarmerlist" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
    
        <AlternatingRowStyle BackColor="White" />
    
        <Columns>
            <asp:BoundField DataField="fullname" HeaderText="Farmer Name" />
            <asp:BoundField DataField="mobileno" HeaderText="Mobile Number" />
            <asp:BoundField DataField="state" HeaderText="State" />
            <asp:BoundField DataField="city" HeaderText="City" />
        </Columns>


        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />


    </asp:GridView>

</center>
    
</div>


</div>


</asp:Content>
