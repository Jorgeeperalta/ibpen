<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ibpen1._2.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"type="text/css"/>

<!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap-theme.min.css"type="text/css" />
    <link rel="stylesheet" href="https:// cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
     <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
    <!-- Latest compiled and minified JavaScript -->
   <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>

</head>
<body class="bg-black">
    <div class="form-box" id="login-box">
        <div class="header bg-blue">Ministerio Ibpen</div>
        <h3 text-align: center> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Inicie Sesion</h3>
    <form id="form1" runat="server">
        <div class="body bg-gray">
            <div class="form-group">

                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Ingrese Usuario" Width="310px"></asp:TextBox>

            </div>
            <div class="form-group">

             <asp:TextBox ID="txtPasswor" runat="server" CssClass="form-control" placeholder="Ingrese Clave" Width="311px"></asp:TextBox>

            </div>
        </div>
        <div class="footer bg-gray">

          
		
        	<asp:Button ID="btnEntrar" runat="server" Text="Entrar" Width="311px"  CssClass="bg-blue btn-block" Height="50px" OnClick="btnEntrar_Click"  />

        <!--  <td colspan="2">
			  <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
          </td> -->

        </div>
    </form>
        </div>
   
</body>
</html>
