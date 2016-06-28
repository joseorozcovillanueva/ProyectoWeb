<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebInsertarInstitucion.aspx.cs" Inherits="ExpedienteElectronico.CatInstitutos.WebInsertarInstitucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../scripts/bootstrap.min.js"></script>
    <script src="../scripts/jquery-2.2.4.min.js"></script>
     <script type="text/javascript">
    function openModal() {
        $('#myModal').modal('show');
        return true;
      //  $('#myModal').on('shown.bs.modal', function () {
      //      $('#myInput').focus()
      //  })
    }  

    function mensaje(unMensaje) {
        alert(unMensaje);
        return false;
    }
</script>
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


