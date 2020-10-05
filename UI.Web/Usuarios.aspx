<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="None" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content title="Usuarios" ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table, th, td {
         border: 1px solid black;
         border-collapse: collapse;
         }
        table.center {
          margin-left:auto; 
          margin-right:auto;
        }
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h1>Usuarios</h1>
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"  DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="700px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
                <asp:BoundField DataField="Habilitado" HeaderText="Habilitado" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>   
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click"> Editar | </asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click"> Eliminar |</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">  Nuevo</asp:LinkButton>
    </asp:Panel>
    <br />
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <table class="center">
            <tr>
                <td><asp:Label ID="nombreLabel" runat="server" Text="Nombre:"></asp:Label></td>
                <td><asp:TextBox ID="nombreTextBox" runat="server" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El nombre no puede estar vacio" ControlToValidate="nombreTextBox">*</asp:RequiredFieldValidator>
                </td>

            </tr>
            <tr>
                <td><asp:Label ID="apellidoLabel" runat="server" Text="Apellido:"></asp:Label></td>
                <td><asp:TextBox ID="apellidoTextBox" runat="server" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="El apellido no puede estar vacio" ControlToValidate="apellidoTextBox">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="emailLabel" runat="server" Text="Email:"></asp:Label></td>
                <td><asp:TextBox ID="emailTextBox" runat="server" Width="150px"></asp:TextBox>  
                    <asp:RegularExpressionValidator ID="rfvEmail" runat="server" ErrorMessage="El email es inválido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="emailTextBox">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado:"></asp:Label></td>
                <td><asp:CheckBox ID="habilitadoCheckBox" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario:"></asp:Label></td>
                <td><asp:TextBox ID="nombreUsuarioTextBox" runat="server" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNombreUsuario" runat="server" ErrorMessage="El nombre de usuario no puede estar vacio" ControlToValidate="nombreUsuarioTextBox" Display="Dynamic">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="claveLabel" runat="server" Text="Clave:"></asp:Label></td>
                <td><asp:TextBox ID="claveTextBox" TextMode="Password" runat="server" Width="150px"></asp:TextBox>                   
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave:"></asp:Label></td>
                <td> <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server" Width="150px"></asp:TextBox>
                    <asp:CompareValidator ID="rfvClave" runat="server" ControlToCompare="claveTextBox" ControlToValidate="repetirClaveTextBox" ErrorMessage="Las claves no coinciden" Display="Dynamic">*</asp:CompareValidator>
                </td>
            </tr>  
            </table>
         <asp:Panel ID="formActionsPanel" HorizontalAlign="Center" runat="server">
             <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidateRequestMode="Enabled"> Aceptar |</asp:LinkButton>
             <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click" CausesValidation="False"> Cancelar</asp:LinkButton>
             <asp:ValidationSummary ID="ValidationSummary1" runat="server" BorderStyle="Dotted" ForeColor="#FF3300" HeaderText="Errores: " DisplayMode="List" />
         </asp:Panel>
    </asp:Panel>  
</asp:Content>
