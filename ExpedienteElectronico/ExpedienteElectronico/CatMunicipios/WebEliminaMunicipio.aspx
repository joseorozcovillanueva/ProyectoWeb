﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebEliminaMunicipio.aspx.cs" Inherits="ExpedienteElectronico.CatMunicipios.WebEliminaMunicipio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container">
      
    <h3>Confirmación de Eliminación | Municipio | ID : <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label></h3> 
                
         <div class="form-group">
           <asp:Label ID="lblEstado"   runat="server" Text="Estado: "></asp:Label>
           <asp:DropDownList ID="dropListEstado" runat="server" CssClass="form-control" Enabled="false" ></asp:DropDownList>
         </div>
             <div class="form-group">
             <asp:Label ID="lblcNombre"   runat="server" Text="Nombre del Municipio: "></asp:Label>
             <asp:TextBox ID="txtcNombre" Enabled="false" CssClass="form-control" runat="server"></asp:TextBox>
             </div>         
         
          <div class="form-group">
           <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
             <asp:Button ID="btnCancelar" OnClick="btnButtonCancelar_Click" CssClass="btn btn-danger" runat="server" Text="Cancelar" />
              </div>
         </div>

        
     </form>
</asp:Content>