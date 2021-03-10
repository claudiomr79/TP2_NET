<%@ Page Title="Menu Alumnos" Language="C#" AutoEventWireup="true" CodeBehind="AlumnoMenu.aspx.cs" Inherits="UI.Web.AlumnoMenu" %>

<head>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>

<form id="form1" runat="server">
    <asp:Label ID="lblTitulo" runat="server" BackColor="#3399FF" Font-Size="20pt" ForeColor="White" Text="Bienvenido al Sitema de Gestión de Alumnos"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Usuario: "></asp:Label>
    <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
    <br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton runat="server" ID="lnbInscripcion" OnClick="lnbInscripcion_Click">Inscripcion a cursado</asp:LinkButton>
    <br />
    <div class="auto-style1">
        <asp:LinkButton runat="server" ID="lnbSalir" OnClick="lnbSalir_Click">Salir</asp:LinkButton>
    </div>
    <br />

</form>


