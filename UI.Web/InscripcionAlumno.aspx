<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InscripcionAlumno.aspx.cs" Inherits="UI.Web.InscripcionAlumno" %>

<form id="form1" runat="server">

<asp:Label runat="server" Text="Inscripción a Cursado" Font-Size="20pt" ForeColor="#0066CC"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Materias a las que puede inscribirse el Usuario:"></asp:Label>
    <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
    <br /><br /><hr /><br /><br />
    <asp:GridView ID="grvMateriasAInscribirse" runat="server" AutoGenerateColumns="False" Width="584px">
        <Columns>
            <asp:BoundField DataField="Descripcion" HeaderText="Materia" ReadOnly="True" />
            <asp:BoundField DataField="Descripcion" HeaderText="Plan" ReadOnly="True" />
            <asp:BoundField DataField="ID" HeaderText="Codigo" ReadOnly="True" />
            <asp:CommandField NewText="Inscribir" ShowDeleteButton="True" ShowInsertButton="True" />
        </Columns>
    </asp:GridView>

</form>
