<%@ Page EnableEventValidation="true" Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebInstitucion.aspx.cs" Inherits="ExpedienteElectronico.CatInstitutos.WebInstitucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container">
      
    <h3>Catálogo de Instituciones <asp:Button ID="btnButtonNuevo" runat="server" CssClass="btn btn-primary" Text="+" OnClick="btnButtonNuevo_Click" /> </h3> 
         <asp:GridView ID="GridViewInstitucion"  CssClass="table table-bordered" AutoGenerateColumns="False" runat="server" >
          <Columns>
                <asp:BoundField DataField="IdInstitucion"  HeaderText="ID" Visible="true" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>

                <asp:BoundField DataField="NombreInstitucion"  HeaderText="Nombre Institución" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="Direccion"  HeaderText="Dirección" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaCreacion"  HeaderText="Fecha Creación" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="lValido"  HeaderText="Institucion Valida" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:TemplateField HeaderStyle-ForeColor="Black"  HeaderText="Opciones">
                    <ItemTemplate>
                        <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary" Text="Editar"  
                             OnClick="Editar"
                             />
                     <asp:Button ID="btnCarreras" runat="server" Text="Carreras" CssClass="btn btn-warning" OnClick="AgrCarrera" />
                     <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger"  OnClick="Eliminar" />
                    </ItemTemplate>
                    

                <HeaderStyle ForeColor="Black" Width="200px"></HeaderStyle>
                </asp:TemplateField>                
            </Columns>   
                
                <RowStyle CssClass="cursor-pointer" />
                
           
         </asp:GridView>

        

         </div>

         

     </form>

   

</asp:Content>
