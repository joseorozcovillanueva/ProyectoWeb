<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebInsertarInstitucion.aspx.cs" Inherits="ExpedienteElectronico.CatInstitutos.WebInsertarInstitucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../scripts/bootstrap.min.js"></script>
    <script src="../scripts/jquery-2.2.4.min.js"></script>
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
      
    <h3>Nuevo Registros | Institución</h3> 
              
         <div class="form-group">
           <asp:Label ID="lblcNombre"   runat="server" Text="Nombre de la Institución: "></asp:Label>
         <asp:TextBox ID="txtcNombre"  CssClass="form-control" runat="server" ></asp:TextBox>
             </div>
         <div class="form-group">
         <asp:Label ID="lblDireccion" runat="server" Text="Dirección: "></asp:Label>
         <asp:TextBox ID="txtcDireccion" CssClass="form-control" runat="server" ></asp:TextBox>
         </div>

        
                 
          <div class="form-group">
           <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click1" />
             <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar" OnClick="btnCancelar_Click1" />
              </div>
         </div>
          

         <div id="Mensaje" class="modal fade" role="dialog">
          <div class="modal-dialog">
            <!-- Modal content-->
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Error</h4>
              </div>
              <div class="modal-body">
                <asp:TextBox ID="cidError" Text="Error" runat="server"></asp:TextBox>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
              </div>
            </div>
         </div>
        </div>
        
       
     </form>
</asp:Content>


