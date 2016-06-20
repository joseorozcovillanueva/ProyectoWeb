﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebEliminaParametro.aspx.cs" Inherits="ExpedienteElectronico.CatParametro.WebEliminaParametro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container">
      
    <h3>Confirmación de Eliminación | Parámetro | ID : <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label></h3> 
                
             <div class="form-group">
             <asp:Label ID="lblcNombre"   runat="server" Text="Nombre del Estado: "></asp:Label>
             <asp:TextBox ID="txtcNombre" Enabled="false" CssClass="form-control" runat="server"></asp:TextBox>
             </div>    
         
          <div class="form-group">
         <asp:Label ID="lblcDescripcion" runat="server" Text="Descripción: "></asp:Label>
         <asp:TextBox ID="txtcDescripcion"  Enabled="false" CssClass="form-control" runat="server" ></asp:TextBox>
         </div>         

         <div class="form-group">
         <asp:Label ID="lblValor"   runat="server" Text="Valor: "></asp:Label>
         <asp:TextBox ID="txtcValor"  Enabled="false" CssClass="form-control" runat="server" ></asp:TextBox>
         </div>         
         
          <div class="form-group">
           <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
             <asp:Button ID="btnCancelar" OnClick="btnButtonCancelar_Click" CssClass="btn btn-danger" runat="server" Text="Cancelar" />
              </div>
         </div>

        
     </form>
</asp:Content>