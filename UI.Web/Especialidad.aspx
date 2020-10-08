<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidad.aspx.cs" Inherits="UI.Web.Especialidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <h1>Especialidad</h1>
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" Width="700px">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" >
                <HeaderStyle BackColor="Aqua" />
                </asp:BoundField>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" >
                <HeaderStyle BackColor="Aqua" />
                </asp:BoundField>
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" >
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
    <br />
    <asp:Panel CssClass="container" ID="formPanel" Visible="false" runat="server">
        <div class="card" style="width: 350px">
            <div class="card-body">
                <table>
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="lblID" runat="server" Text="ID:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtID" runat="server" Text="" Enabled="False"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label CssClass="alert-info" ID="lblDescripcion" runat="server" Text="Descripción Especialidad:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtDescripcion" runat="server" Width="150px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ErrorMessage="La descripción no puede estar vacia" ControlToValidate="txtDescripcion">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="formActionsPanel" HorizontalAlign="Center" runat="server">
                    <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidateRequestMode="Enabled"> Aceptar |</asp:LinkButton>
                    <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click" CausesValidation="False"> Cancelar</asp:LinkButton>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BorderStyle="Dotted" ForeColor="#FF3300" HeaderText="Errores: " DisplayMode="List" />
                </asp:Panel>
            </div>
        </div>    
    </asp:Panel> 
</asp:Content>
