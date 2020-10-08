<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="None" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<asp:Content title="Usuarios" ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h1>Usuarios</h1>
    <div>
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" Width="700px">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre">
                        <HeaderStyle BackColor="Aqua" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido">
                        <HeaderStyle BackColor="Aqua" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Email" HeaderText="Email">
                        <HeaderStyle BackColor="Aqua" />
                    </asp:BoundField>
                    <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario">
                        <HeaderStyle BackColor="Aqua" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Habilitado" HeaderText="Habilitado">
                        <HeaderStyle BackColor="Aqua" />
                    </asp:BoundField>
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True">
                        <HeaderStyle BackColor="Aqua" />
                    </asp:CommandField>
                </Columns>
                <SelectedRowStyle CssClass="alert-info" />
            </asp:GridView>
        </asp:Panel>
        <asp:Panel ID="gridActionsPanel" runat="server">
            <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click"> Editar | </asp:LinkButton>
            <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click"> Eliminar |</asp:LinkButton>
            <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">  Nuevo</asp:LinkButton>
        </asp:Panel>
    </div>
    <br />
    <asp:Panel ID="formPanel" Visible="false" runat="server" BorderStyle="None">
        <div class="card" style="width: 350px">
            <div class="card-body">
                <table class="table">
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="nombreLabel" runat="server" Text="Nombre:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="nombreTextBox" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El nombre no puede estar vacio" ControlToValidate="nombreTextBox">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="apellidoLabel" runat="server" Text="Apellido:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="apellidoTextBox" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="El apellido no puede estar vacio" ControlToValidate="apellidoTextBox">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="emailLabel" runat="server" Text="Email:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="emailTextBox" runat="server" Width="150px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="rfvEmail" runat="server" ErrorMessage="El email es inválido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="emailTextBox">*</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="habilitadoLabel" runat="server" Text="Habilitado:"></asp:Label></td>
                        <td>
                            <asp:CheckBox ID="habilitadoCheckBox" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="nombreUsuarioLabel" runat="server" Text="Usuario:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="nombreUsuarioTextBox" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvNombreUsuario" runat="server" ErrorMessage="El nombre de usuario no puede estar vacio" ControlToValidate="nombreUsuarioTextBox" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="claveLabel" runat="server" Text="Clave:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="claveTextBox" TextMode="Password" runat="server" Width="150px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="repetirClaveLabel" runat="server" Text="Repetir Clave:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server" Width="150px"></asp:TextBox>
                            <asp:CompareValidator ID="rfvClave" runat="server" ControlToCompare="claveTextBox" ControlToValidate="repetirClaveTextBox" ErrorMessage="Las claves no coinciden" Display="Dynamic">*</asp:CompareValidator>
                            <asp:RequiredFieldValidator ID="rfvClaveReq" runat="server" ErrorMessage="La clave no puede estar vacia" ControlToValidate="repetirClaveTextBox" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="formActionsPanel" runat="server">
                    <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidateRequestMode="Enabled"> Aceptar |</asp:LinkButton>
                    <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click" CausesValidation="False"> Cancelar</asp:LinkButton>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BorderStyle="Dotted" ForeColor="#FF3300" HeaderText="Errores: " DisplayMode="List" />
                </asp:Panel>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
