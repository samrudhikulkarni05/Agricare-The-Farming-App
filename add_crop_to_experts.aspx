<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="add_crop_to_experts.aspx.cs" Inherits="farmerapp.add_crop_to_experts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="margin-top:5%; padding:50px" class="container shadow rounded bg-light">

    <asp:DropDownList ID="drdexpert" CssClass="form-select form-select-sm" runat="server">
    </asp:DropDownList>
    <br />
    <asp:DropDownList ID="drdcrop" CssClass="form-select form-select-sm" runat="server">
    </asp:DropDownList>
</div>


<div style="margin-top:10px; text-align:right">
            <asp:Button CssClass="btn btn-sm btn-primary" ID="btnadd" runat="server" 
                Text="Add" onclick="btnadd_Click" />
            <asp:Button CssClass="btn btn-sm btn-danger" ID="btncancel" runat="server" 
                Text="Cancel" CausesValidation="False" />
        </div>


    <div>
        <center>
        <asp:GridView AutoGenerateColumns="False" ID="gvexpertcrop" runat="server" 
                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" GridLines="Horizontal" 
                onrowcommand="gvexpertcrop_RowCommand" onrowcreated="gvexpertcrop_RowCreated">
                
                <Columns>
                    <asp:BoundField DataField="expertname" HeaderText="Expert Name" />
                    <asp:BoundField DataField="cropname" HeaderText="Crop Name" />

                </Columns>
                  
                  <Columns>
                  <asp:TemplateField>
                     <ItemTemplate>
                       <asp:Button CommandArgument=<%#Eval("ecid")%> ID="btnec" text="Delete" runat="server" CssClass="btn btn-sm btn-danger" />



                       </button>
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




</asp:Content>
