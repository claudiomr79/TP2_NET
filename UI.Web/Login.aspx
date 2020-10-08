<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }
        .auto-style1 {
            display: block;
            width: 100%;
            height: calc(1.5em + .75rem + 2px);
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            background-clip: padding-box;
            border-radius: .25rem;
            transition: none;
            left: 0px;
            top: 0px;
            border: 1px solid #ced4da;
            background-color: #fff;
        }
    </style>
    <!-- Custom styles for this template -->
    <link href="Content/signin.css" rel="stylesheet">
</head>
<body class="text-center">
    <form id="Login" class="form-signin" runat="server">      
        <asp:Image ID="Image1" CssClass="mb-4"  runat="server" ImageUrl="~/Imagenes/utn.jpg" Height="72px" Width="72px" />
        <h1 class="h3 mb-3 font-weight-normal">Sistema Académico</h1>
        <asp:Label text="Nombre de Usuario" CssClass="sr-only" ID="lblNombreUsuario" runat="server"></asp:Label>
        <asp:TextBox ID="txtNombreUsuario" CssClass="form-control" placeholder="Nombre de Usuario" required="" runat="server"></asp:TextBox>
        
        <asp:Label text="Password" CssClass="sr-only" ID="lblPassword" runat="server"></asp:Label>
        <asp:TextBox ID="txtPassword" CssClass="form-control" placeholder="Password" required="" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLoguearse" CssClass="btn btn-lg btn-primary btn-block" Text="Loguearse" runat="server"  OnClick="btnLoguearse_Click" />
        <asp:Label ID="lblLogIn" Text="" Visible="false" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC3300"></asp:Label>
        <p class="mt-5 mb-3 text-muted">Sistema Académico-2020</p>
    </form>
</body>
</html>
