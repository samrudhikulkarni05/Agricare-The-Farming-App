<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="experts.aspx.cs" Inherits="farmerapp.experts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="margin-top:5%; padding:50px" class="container bg-light">
    
    <h3>Add Experts</h3>

    <asp:TextBox placeholder="Enter Full Name" CssClass="form-control form-control-sm" ID="txtfullname" 
        runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Enter Full Name" ControlToValidate="txtfullname" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:TextBox placeholder="Enter Email id" CssClass="form-control form-control-sm" ID="txtemail" 
        runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="Enter Email id" ControlToValidate="txtemail" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="txtemail" ErrorMessage="Enter Valid Email id" 
        ForeColor="Red" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <asp:TextBox placeholder="Enter Mobile Number" CssClass="form-control form-control-sm" ID="txtmobile" 
        runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ErrorMessage="Enter Mobile Number" ControlToValidate="txtmobile" 
        ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="txtmobile" ErrorMessage="Enter 10 digit Number" 
        ForeColor="Red" ValidationExpression="^[0-9]{10}"></asp:RegularExpressionValidator>
    <asp:TextBox placeholder="Enter Password" CssClass="form-control form-control-sm" ID="txtpass" 
        runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ErrorMessage="Enter Password" ControlToValidate="txtpass" ForeColor="Red"></asp:RequiredFieldValidator>


        <div style="margin-top:10px; text-align:right">
            <asp:Button CssClass="btn btn-sm btn-primary" ID="btnadd" runat="server" 
                Text="Add" onclick="btnadd_Click" />
            <asp:Button CssClass="btn btn-sm btn-danger" ID="btncancel" runat="server" 
                Text="Cancel" CausesValidation="False" />
        </div>


    
    <div style="margin-top:25px;  ">
        <center>
            <asp:GridView ID="gvexpert" AutoGenerateColumns="False" runat="server" 
                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" GridLines="Horizontal" onrowcommand="gvexpert_RowCommand">
                
                <Columns>
                    <asp:BoundField DataField="fullname" HeaderText="Expert Full Name" />
                    <asp:BoundField DataField="emailid" HeaderText="Email Id" />
                    <asp:BoundField DataField="mobile" HeaderText="Mobile Number" />
                </Columns>

                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CausesValidation="false" runat="server" ID="btndel" Text="Delete" CssClass="btn btn-sm btn-outline-danger" CommandArgument=<%#Eval("eid")%> />
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
