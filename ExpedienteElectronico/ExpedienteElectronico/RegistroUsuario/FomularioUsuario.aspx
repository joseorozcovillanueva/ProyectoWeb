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
                 <table>
                     <tr>
                         <td>
                             <asp:Label ID="lblNombre" runat="server" Text="Nombre(s): "></asp:Label>
                             <asp:TextBox ID="TxtNombre" width="300" runat="server"></asp:TextBox>
                         </td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td>
                             <asp:Label ID="lblMatricula" runat="server" Text="Matricula: "></asp:Label>
                             <asp:TextBox ID="txtMatricula" Width="300" runat="server"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="lblApePat" runat="server" Text="Apellido Paterno: "></asp:Label>
                             <asp:TextBox ID="txtApePat" width="300" runat="server"></asp:TextBox>
                         </td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td>
                             <asp:Label ID="lblEstado" runat="server" Text="Estado: "></asp:Label>
                             <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="lblApeMat" runat="server" Text="Apellido Materno: "></asp:Label>
                             <asp:TextBox ID="txtApeMat" width="300" runat="server"></asp:TextBox>
                         </td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td>
                             <asp:Label ID="lblMunicipio" runat="server" Text="Municipio: "></asp:Label>
                             <asp:DropDownList ID="ddlMunicipio" runat="server"></asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="lblDireccion" runat="server" Text="Dirección: "></asp:Label>
                             <asp:TextBox ID="txtDireccion" width="300" runat="server"></asp:TextBox>
                         </td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td>
                             <asp:Label ID="lblCurp" runat="server" Text="CURP: "></asp:Label>
                             <asp:TextBox ID="txtCURP" Width="300" runat="server"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="lblTelefono" runat="server" Text="Teléfono: "></asp:Label>
                             <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                         </td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td>
                             <asp:Label ID="lblInstituto" runat="server" Text="Instituto: "></asp:Label>
                             <asp:DropDownList ID="ddlInstituto" runat="server"></asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                             <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                         </td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td width="50"></td>
                         <td>
                             <asp:Label ID="lblCarrera" runat="server" Text="Carrera: "></asp:Label>
                             <asp:DropDownList ID="ddlCarrera" runat="server"></asp:DropDownList>
                         </td>
                     </tr>
                 </table>
             </form>
             
         </div>
   
</asp:Content>
