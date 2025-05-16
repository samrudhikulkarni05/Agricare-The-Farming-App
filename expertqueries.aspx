<%@ Page Title="" Language="C#" MasterPageFile="~/expert.Master" AutoEventWireup="true" CodeBehind="expertqueries.aspx.cs" Inherits="farmerapp.expertqueries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




<div style="margin-top:5%; padding:50px" class="shadow">

<div class="row">
<asp:Repeater runat="server" ID="repqueries" onitemcommand="repqueries_ItemCommand">
    
    <ItemTemplate>
            <div class="col-sm-3">
                  
                  <div class="shadow p-2 m-2">
                  <center>
                  <p style="font-size:12px">Farmer Question</p> 
                  <p><%#Eval("querydetails")%> </p>
                  <a href=<%#Eval("nfile")%>>  <img src=<%#Eval("nfile")%> width="200px" height="200px" /></a>
                  <br /><br />
                    <asp:Button runat="server" ID="btnreply" Text="Add Reply" CssClass="btn btn-sm btn-success" CommandArgument=<%#Eval("qid")%> />
                </center>
            </div></div>
    </ItemTemplate>
</asp:Repeater>
</div>
</div>


</asp:Content>
