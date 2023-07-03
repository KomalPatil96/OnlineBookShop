<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Selling.aspx.cs" Inherits="OnlineBookShop.Views.Seller.Selling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script type="text/javascript">
            function PrintBill() {
                var PGrid = document.getElementById('<%=BillList.ClientID%>');
                PGrid.bordr = 0;
                var PWin = window.open('', 'PrintGrid', 'left=100 top=100,width=1024,height=768,tollbar=0,scrollbar=1,status=0,resizable=1');
                PWin.document.write(PGrid.outerHTML);
                PWin.document.close();
                PWin.focus();
                PWin.print();
                PWin.close();

            }
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">


    <div class="container-fluid">
        <div class="row">

        </div>
        <div class="row">
            <div class="col-md-5">
                 <h3 class="text-center" style="color:teal;">Book Details</h3>
                 <div class="row">
                    <div class="col">
                         <div class="mt-3">
                            <asp:Label for="" ID="Label1" runat="server" class="form-label text-success">Book Name</asp:Label>
                             <input runat="server" type="text" placeholder="Name" autocomplete="off" class="form-control" id="BNameTb"/>
                        </div>
                    </div>

                      <div class="col">
                         <div class="mt-3">
                            <asp:Label for="" ID="Label2" runat="server" class="form-label text-success">Book Price</asp:Label>
                             <input id="BPriceTb" runat="server" type="text" placeholder="Price" autocomplete="off" class="form-control"/>
                        </div>
                    </div>
               </div>

             

                <div class="row">
                    <div class="col">
                         <div class="mt-3">
                            <asp:Label for="" ID="Label3" runat="server" class="form-label text-success">Book Quantity</asp:Label>
                             <input id="BQtyTb" runat="server" type="text" placeholder="Quantity" autocomplete="off" class="form-control"/>
                        </div>
                    </div>

                      <div class="col">
                         <div class="mt-3">
                            <asp:Label for="" ID="Label4" runat="server" class="form-label text-success">Billing Date</asp:Label>
                             <input id="DateTb" runat="server" type="datetime" class="form-control"/>
                        </div>
                    </div>
                  
               </div>
                 <br /><br />
                  <div class="row-mt-3 mb-3">
                         <div class="col-d-grid">
                              <asp:Button runat="server" Text="Add To Print" ID="Button1" class="btn-warning btn-block btn text-center" OnClick="Button1_Click"/>
                        </div>
                    </div>

               <div class="row mt-5">
                   <h4 class="text-center" style="color:teal;">Book List</h4>
                      <div class="col">
                    <asp:GridView ID="BookList" runat="server"  class="table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorList_SelectedIndexChanged">
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

              <div class="col-md-7">
                     <h4 class="text-center" style="color: crimson;">Client's Bill</h4>
                      <div class="col">
                    <asp:GridView ID="BillList" runat="server"  class="table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorList_SelectedIndexChanged">
                  <AlternatingRowStyle BackColor="White" />
                  <EditRowStyle BackColor="#7C6F57" />
                  <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                  <HeaderStyle BackColor="SlateBlue" Font-Bold="false" ForeColor="White" />
                  <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                  <RowStyle BackColor="#E3EAEB" />
                  <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                  <SortedAscendingCellStyle BackColor="#F8FAFA" />
                  <SortedAscendingHeaderStyle BackColor="#246B61" />
                  <SortedDescendingCellStyle BackColor="#D4DFE1" />
                  <SortedDescendingHeaderStyle BackColor="#15524A" />
              </asp:GridView>

                 <div class="d-grid">
                       <asp:Label ID="GrdTotalTb" runat="server" class="text-danger text-center"></asp:Label>
                        <asp:Button runat="server" Text="Print" ID="PrintBtn" OnClientClick="PrintBill()" class="btn-warning btn-block btn " OnClick="PrintBtn_Click"/>
                  </div>
                           
                </div>
        </div>
        </div>
    </div>

</asp:Content>
