<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebModificaCarrera.aspx.cs" Inherits="WebExpedienteElectronico.WebModificaCarrera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container">
      
    <h3>Edición de Registro | Carrera | ID : <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
         </h3> 
         <div class="form-group">
         <asp:Label ID="Label1"   runat="server" Text="Nombre de la Institución: "></asp:Label>
         <asp:CheckBox runat="server" Text="Valido" ID="chbValido" />
         <asp:CheckBox ID="chbCancelado" runat="server" Text="Cancelado" />
         <asp:DropDownList ID="ddlInstitucion" runat="server" CssClass="form-control" Enabled="false" ></asp:DropDownList>                  
         </div>
         
         <div class="form-group">
         <asp:Label ID="lblcNombre"   runat="server" Text="Nombre de la Carrera: "></asp:Label>
         <asp:TextBox ID="txtcNombre"  CssClass="form-control" runat="server"></asp:TextBox>
         </div>

         
          <div class="form-group">             
           <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
             <asp:Button ID="btnCancelar" OnClick="btnButtonCancelar_Click" CssClass="btn btn-danger" runat="server" Text="Cancelar" />
              </div>
         </div>         
       
     </form>
</asp:Content>