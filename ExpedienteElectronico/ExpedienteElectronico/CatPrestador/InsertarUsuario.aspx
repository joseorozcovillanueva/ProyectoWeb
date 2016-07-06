<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="InsertarUsuario.aspx.cs" Inherits="ExpedienteElectronico.CatPrestador.InsertarUsuario" %>

<script runat="server">

    protected void btnGuardar_Click(object sender, EventArgs e)
    {

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {

    }
</script>


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
      
    <h3>Nuevo Registros | </h3> 
              
         
         
         <div class="form-group">
         <asp:Label ID="lblcNombrePrestador"   runat="server" Text="Nombre(s) : "></asp:Label>
         <asp:TextBox ID="txtcNombrePrestador"  CssClass="form-control" runat="server" ></asp:TextBox>
         </div>   
          <div class="form-group">
         <asp:Label ID="lblAppellido"   runat="server" Text="Apellido Paterno : "></asp:Label>
         <asp:TextBox ID="TxtApellido"  CssClass="form-control" runat="server" ></asp:TextBox>
         </div>        
         <div class="form-group">
         <asp:Label ID="lblAppellidoMat"   runat="server" Text="Apellido Materno : "></asp:Label>
         <asp:TextBox ID="txtApellidoMat"  CssClass="form-control" runat="server" ></asp:TextBox>
         </div> 
         <div class="form-group">
         <asp:Label ID="lblDireccion"   runat="server" Text="Direccion : "></asp:Label>
         <asp:TextBox ID="txtDireccion"  CssClass="form-control" runat="server" ></asp:TextBox>
         </div>
         <div class="form-group">
         <asp:Label ID="lblTel"   runat="server" Text="Telefono : "></asp:Label>
         <asp:TextBox ID="txtTel"  CssClass="form-control" runat="server" TextMode="Number" ></asp:TextBox>
         </div>
         <div class="form-group">
         <asp:Label ID="lblMatricula"   runat="server" Text="Matricula : "></asp:Label>
         <asp:TextBox ID="txtMatricula"  CssClass="form-control" runat="server" ></asp:TextBox>
         </div>
          <div class="form-group">
         <asp:Label ID="lblEstado"   runat="server" Text="Estado : "></asp:Label>
         <asp:TextBox ID="txtEstado"  CssClass="form-control" runat="server" ></asp:TextBox>
         </div>
         <div class="form-group">
           <asp:Label ID="lblMunicipio"   runat="server" Text="Municipio: "></asp:Label>
           <asp:DropDownList ID="dropListMunicipio" runat="server" CssClass="form-control" Enabled="false" ></asp:DropDownList>
         </div>
          <div class="form-group">
         <asp:Label ID="lblCurp"   runat="server" Text="CURP : "></asp:Label>
         <asp:TextBox ID="txtCurp"  CssClass="form-control" runat="server" ></asp:TextBox>
         </div>
         <div class="form-group">
           <asp:Label ID="lblInstituto"   runat="server" Text="Instituto : "></asp:Label>
           <asp:DropDownList ID="DropListInst" runat="server" CssClass="form-control" Enabled="false" ></asp:DropDownList>
         </div>
         <div class="form-group">
           <asp:Label ID="lblCarrera"   runat="server" Text="Carrera : "></asp:Label>
           <asp:DropDownList ID="DropListCarrera" runat="server" CssClass="form-control" Enabled="false" ></asp:DropDownList>
         </div>
          <div class="form-group">
         <asp:Label ID="lblEmail"   runat="server" Text="EMAIL : "></asp:Label>
         <asp:TextBox ID="txtEmail"  CssClass="form-control" runat="server" TextMode="Email" ></asp:TextBox>
         </div>    
          <div class="form-group">
         <asp:Label ID="lblPass"   runat="server" Text="Password : "></asp:Label>
         <asp:TextBox ID="txtPass"  CssClass="form-control" runat="server" TextMode="Password" ></asp:TextBox>
         </div>   
          <div class="form-group">
         <asp:Label ID="lblConfpass"   runat="server" Text="Confirmacion Password : "></asp:Label>
         <asp:TextBox ID="txtConfpass"  CssClass="form-control" runat="server" TextMode="Password" ></asp:TextBox>
         </div>       
                    
          <div class="form-group">
           <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
             <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar"  OnClick="btnCancelar_Click" />
              </div>
         </div>
        
       
     </form>
</asp:Content>