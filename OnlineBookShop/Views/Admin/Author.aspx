<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="OnlineBookShop.Views.Admin.Author" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <div class="container-fluid">
    <div class="row">
         <div class="col">
             <h3 class="text-center">Manage Author</h3>
         </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                  <asp:Label for="" ID="Label1" runat="server" class="form-label text-info">Author Name</asp:Label>
                  <input type="text" placeholder="Title" autocomplete="off" class="form-control" runat="server" id="ANameTb"/>
            </div>
             <div class="mb-3">
                  <asp:Label for="" ID="Label2" runat="server" class="form-label text-info">Author Gender</asp:Label>             
                  <asp:DropDownList iD="GenCb" runat="server" class="form-control">
                       <asp:ListItem>Male</asp:ListItem>
                       <asp:ListItem>Female</asp:ListItem>
                  </asp:DropDownList>
            </div>
             <div class="mb-3">
                  <asp:Label for="" ID="Label3" runat="server" class="form-label text-info">Country</asp:Label>
                  <asp:DropDownList ID="CountryCb" runat="server" class="form-control">
                      <asp:ListItem>USA</asp:ListItem>
                      <asp:ListItem>India</asp:ListItem>
                      <asp:ListItem>France</asp:ListItem>
                      <asp:ListItem>UK</asp:ListItem>
                      <asp:ListItem>Spain</asp:ListItem>
                      <asp:ListItem>Other</asp:ListItem>
                  </asp:DropDownList>
                 
            </div>
              <div class="row">
                    <asp:Label ID="ErrMsg" runat="server" class="text-danger"></asp:Label>
                 
               </div>

             <div class="row">
               
                 <div class="col d-grid">
                      <asp:Button runat="server" Text="Update" ID="EditBtn" class="btn-warning btn-block btn " OnClick="EditBtn_Click"/>
                 </div>
                 <div class="col d-grid">
                      <asp:Button runat="server" Text="Save" ID="SaveBtn" class="btn-success btn-block btn " OnClick="SaveBtn_Click"/>
                 </div>
                 <div class="col d-grid">
                      <asp:Button runat="server" Text="Delete" ID="DeleteBtn" class="btn-danger btn-block btn " OnClick="DeleteBtn_Click"/>
                 </div>
             </div>
        </div>
          <div class="col-md-8">
              <asp:GridView ID="AuthorList" runat="server"  class="table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorList_SelectedIndexChanged">
                  <AlternatingRowStyle BackColor="White" />
                  <EditRowStyle BackColor="#7C6F57" />
                  <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                  <HeaderStyle BackColor="teal" Font-Bold="false" ForeColor="White" />
                  <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                  <RowStyle BackColor="#E3EAEB" />
                  <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                  <SortedAscendingCellStyle BackColor="#F8FAFA" />
                  <SortedAscendingHeaderStyle BackColor="#246B61" />
                  <SortedDescendingCellStyle BackColor="#D4DFE1" />
                  <SortedDescendingHeaderStyle BackColor="#15524A" />
              </asp:GridView>
        </div>
    </div>
</div>
</asp:Content>
