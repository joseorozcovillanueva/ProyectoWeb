﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebModificaInstitucion.aspx.cs" Inherits="ExpedienteElectronico.CatInstitutos.WebModificaInstitucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container">
      
    <h3>Edición de Registro | Institución | ID : <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
         </h3> 
                
         <div class="form-group">
         <asp:Label ID="lblcNombre"   runat="server" Text="Nombre de la Institución: "></asp:Label>
         <asp:TextBox ID="txtcNombre"  CssClass="form-control" runat="server"></asp:TextBox>
         </div>

         <div class="form-group">
         <asp:Label ID="lblDireccion" runat="server" Text="Dirección: "></asp:Label>
         <asp:TextBox ID="txtcDireccion" CssClass="form-control" runat="server" ></asp:TextBox>
         </div>

         
          <div class="form-group">
           <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
             <asp:Button ID="btnCancelar" OnClick="btnButtonCancelar_Click" CssClass="btn btn-danger" runat="server" Text="Cancelar" />
              </div>
         </div>
       
     </form>
</asp:Content>