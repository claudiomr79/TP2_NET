<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
 
    <div class="row">
        <div class="col-1"></div>
            <div class="col-10"> 
            <h1>Personas</h1>     
            <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" Width="700px">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Email" HeaderText="Email" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha Nacimiento" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="IdPlan" HeaderText="Id plan" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Legajo" HeaderText="Legajo" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" >
                        <HeaderStyle BackColor="Aqua" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TipoPersona" HeaderText="Tipo" >
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
            </div>
        <div class="col-1"></div>       
    </div>
     <br />
    <div class="row">
        <div class="col-3"></div>
            <div class="col-6">        
            <asp:Panel CssClass="container" ID="formPanel" Visible="false" runat="server">
                <div class="card" style="width: 350px">
                    <div class="card-body">
                        <table>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblID" runat="server" Text="ID:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtID" runat="server" Text="" Enabled="False" Width="159px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblApellido" runat="server" Text="Apellido:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtApellido" runat="server" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="El apellido no puede estar vacio" ControlToValidate="txtApellido">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblNombre" runat="server" Text="Nombre:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtNombre" runat="server" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El Nombre no puede estar vacio" ControlToValidate="txtNombre">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtDireccion" runat="server" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ErrorMessage="La direccion no puede estar vacio" ControlToValidate="txtDireccion">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblEmail" runat="server" Text="Email:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox>
                                     <asp:RegularExpressionValidator ID="rfvEmail" runat="server" ErrorMessage="El email es inválido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail">*</asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblFechaNacimiento" runat="server" Text="Fecha Nacimiento:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtFechaNacimiento" runat="server" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvFechaNac" runat="server" ErrorMessage="La Fecha no puede estar vacia" ControlToValidate="txtFechaNacimiento">*</asp:RequiredFieldValidator> 
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblIdPlan" runat="server" Text="IdPlan:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtIdPlan" runat="server" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvIdPlan" runat="server" ErrorMessage="El Id del plan no puede estar vacio" ControlToValidate="txtIdPlan">*</asp:RequiredFieldValidator>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblLegajo" runat="server" Text="Legajo:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtLegajo" runat="server" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" ErrorMessage="El legajo no puede estar vacio" ControlToValidate="txtLegajo">*</asp:RequiredFieldValidator>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtTelefono" runat="server" Width="150px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ErrorMessage="El telefono no puede estar vacio" ControlToValidate="txtTelefono">*</asp:RequiredFieldValidator>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label CssClass="alert-info" ID="lblTipo" runat="server" Text="Tipo:"></asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="ddlTipo" runat="server" Width="161px">                                       
                                    </asp:DropDownList>                              
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
            </div>
        <div class="col-3"></div>       
    </div>
   
</asp:Content>
