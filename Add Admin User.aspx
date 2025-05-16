<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Add Admin User.aspx.cs" Inherits="farmerapp.Add_Admin_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


  <div class="container shadow" style="margin-top:5%; padding:50px; background-color:#CCCCFF">

        <h3>Add Admin User </h3>

        <asp:TextBox placeholder="Enter User Name" ID="txtusername" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtusername" ErrorMessage="Enter User Name" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox placeholder="Enter Password" CssClass="form-control form-control-sm" TextMode="Password" ID="txtpass" runat="server"></asp:TextBox>      
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtpass" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
        
        <br/>
        <asp:Button CssClass="btn btn-outline-success btn-sm" ID="btnlogin" 
            runat="server" Text="Add Admin User" onclick="btnlogin_Click" />
          

          <div style="margin-top:20px">
            <center>
                <asp:GridView runat="server" ID="gvadmin" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    onrowcommand="gvadmin_RowCommand">
                
                    <AlternatingRowStyle BackColor="White" />
                
                    <Columns>
                        <asp:BoundField DataField="aname" HeaderText="Admin User Name" />
                       
                    </Columns>
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button CommandArgument=<%#Eval("id")%> runat="server" ID="btndeluser" Text="Delete" CausesValidation="false" class="btn btn-sm"/>
                            </ItemTemplate>
                        </asp:TemplateField>
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
