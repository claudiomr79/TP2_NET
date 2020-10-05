<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidad.aspx.cs" Inherits="UI.Web.Especialidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    <h1>Especialidad</h1>
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"  DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="700px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
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
                <td><asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label></td>
                <td><asp:TextBox ID="txtID" runat="server" Text="" Enabled="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDescripcion" runat="server" Text="Descripción Especialidad:"></asp:Label></td>
                <td><asp:TextBox ID="txtDescripcion" runat="server" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ErrorMessage="La descripción no puede estar vacia" ControlToValidate="txtDescripcion">*</asp:RequiredFieldValidator>
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
