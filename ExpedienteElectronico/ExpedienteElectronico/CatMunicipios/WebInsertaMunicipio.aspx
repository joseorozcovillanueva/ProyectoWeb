<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebInsertaMunicipio.aspx.cs" Inherits="ExpedienteElectronico.CatMunicipios.WebInsertaMunicipio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .auto-style2 {
            position: relative;
            display: block;
            margin-top: 10px;
            margin-bottom: 10px;
            left: 0px;
            top: 0px;
        }
        .auto-style3 {
            left: 0px;
            top: 0px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container" >
      
    <h3>Nuevo Registros | Municipio  del Estado ID : <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label></h3> 
              
         <div class="form-group">
           <asp:Label ID="lblEstado"   runat="server" Text="Estado: "></asp:Label>
           <asp:DropDownList ID="dropListEstado" runat="server" CssClass="form-control" Enabled="false" ></asp:DropDownList>
         </div>
         
         <div class="form-group">
         <asp:Label ID="lblcNombre"   runat="server" Text="Nombre del Municipio: "></asp:Label>
         <asp:TextBox ID="txtcNombre"  CssClass="form-control" runat="server" ></asp:TextBox>
         </div>         
                          
          <div class="form-group">
           <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
             <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar"  OnClick="btnCancelar_Click" />
              </div>
         </div>
        
       
     </form>
</asp:Content>


