<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebModificaInstitucion.aspx.cs" Inherits="ExpedienteElectronico.CatInstitutos.WebModificaInstitucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">      
    <link href="../Content/css/bootstrap3.3.6.min.css" rel="stylesheet" />
    <script src="../scripts/jquery1.12.2.min.js"></script>  
    <script src="../scripts/bootstrap3.3.6.min.js"></script>
    <script type="text/javascript">        
         function openModal() {

             $(document).ready(function () {                 
                     $("#myModal").modal();                 
             });
         }    

    function mensaje(unMensaje) {
        alert(unMensaje);
        return false;
    }
</script>
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

         <div class="form-group">         
            <asp:TextBox ID="TxtcNombre1"  CssClass="form-control" runat="server" Visible="false"></asp:TextBox>
         </div>

         <div class="form-group">
           <asp:TextBox ID="txtcDireccion1" CssClass="form-control" runat="server"  Visible="false"></asp:TextBox>
         </div>
   <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>    
<div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title"><asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                    </div>
                    <div class="modal-body">
                        <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="modal-footer">
                        <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Close</button>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</div>         
    
     </form>
</asp:Content>