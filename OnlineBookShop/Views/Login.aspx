<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineBookShop.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Assest/Lib/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>

    <div class="container-fluid">
        <div class="row mt-5 mb-5">

        </div>

         <div class="row">
              <div class="col-md-4">

              </div>

              <div class="col-md-4">
                   <form id="form1" runat="server">
                       <div>
                           <center>
                               <img width="100px" src="../Assest/Images/userlogin.png" />
                            </center>
                       </div>
                     <div class="mt-3">
                         <asp:Label for="" ID="Label1" runat="server" class="form-label">User Name</asp:Label>
                         <input id="UnameTb" runat="server" type="email" placeholder="Your Email here" autocomplete="off" class="form-control"/>
                     </div>

                     <div class="mt-3">
                         <asp:Label for="" ID="Label2" runat="server" class="form-label">Password</asp:Label>
                         <input id="PasswordTb" runat="server" type="password" placeholder="Password" autocomplete="off" class="form-control"/>
                     </div>

                    <div class="mt-3 d-grid">
                          <asp:Label ID="ErrMsg" runat="server" class="text-danger"></asp:Label><br />
                        <asp:Button ID="LoginBtn" runat="server" Text="Login" class="btn-success btn-block btn" OnClick="LoginBtn_Click"/>
                    </div>
               </form>
             </div>

              <div class="col-md-4">

              </div>
              
        </div>
    </div>

  
</body>
</html>
