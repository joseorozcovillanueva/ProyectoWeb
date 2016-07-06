<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Principal.Master" CodeBehind="FomularioUsuario.aspx.cs" Inherits="ExpedienteElectronico.RegistroUsuario.FomularioUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
         <br />
        <br />
        <br />
    
        <div class="container">
             <h3>Registro de Usuario </h3>
             <br />
            <form id="form1" runat="server">
                <div class="row">
                    <div class="col-sm-4">
                        <table>
                            <tr>
                                <td style="text-align:justify">
                                    <asp:Label ID="lblNombre" runat="server" Text="Nombre(s): "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TxtNombre" width="300" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:justify" width="100">
                                    <asp:Label ID="lblApePat" runat="server"  Text="Apellido Paterno: "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtApePat" width="300" runat="server"></asp:TextBox>
                                </td> 
                            </tr>
                            <tr>
                                <td style="text-align:justify">
                                    <asp:Label ID="lblApeMat" runat="server" Text="Apellido Materno: "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtApeMat" width="300" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblDireccion" runat="server" Text="Dirección: "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtDireccion" width="300" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblTelefono" runat="server" Text="Teléfono: "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </div>                   
                    <div class="col-sm-4">
                        <table>
                             <tr>
                                 <td>
                                     <asp:Label ID="lblMatricula" runat="server" Text="Matricula: "></asp:Label>
                                 </td>
                                 <td>
                                     <asp:TextBox ID="txtMatricula" Width="300" runat="server"></asp:TextBox>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     <asp:Label ID="lblEstado" runat="server" Text="Estado: "></asp:Label>
                                 </td>
                                 <td>
                                     <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     <asp:Label ID="lblMunicipio" runat="server" Text="Municipio: "></asp:Label>
                                 </td>
                                 <td>
                                     <asp:DropDownList ID="ddlMunicipio" runat="server"></asp:DropDownList>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     <asp:Label ID="lblCurp" runat="server" Text="CURP: "></asp:Label>
                                 </td>
                                 <td>
                                     <asp:TextBox ID="txtCURP" Width="300" runat="server"></asp:TextBox>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     <asp:Label ID="lblInstituto" runat="server" Text="Instituto: "></asp:Label>
                                 </td>
                                 <td>
                                     <asp:DropDownList ID="ddlInstituto" runat="server"></asp:DropDownList>
                                 </td>
                             </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblCarrera" runat="server" Text="Carrera: "></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlCarrera" runat="server"></asp:DropDownList>
                                </td>
                            </tr>
                     </table>
                 </div>
                    <div class="col-sm-4">
                        <div class="well">
                            <p>Some text..</p>
                        </div>
                        <div class="well">
                            <p>Some text..</p>
                        </div>
                    </div>                 
            </div>
            </form>
        </div>
</asp:Content>
