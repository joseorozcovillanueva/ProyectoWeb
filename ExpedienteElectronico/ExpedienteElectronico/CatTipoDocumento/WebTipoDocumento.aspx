<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebTipoDocumento.aspx.cs" Inherits="ExpedienteElectronico.CatTipoDocumento.WebTipoDocumento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container">
      
    <h3>Catálogo de Parámetros |&nbsp;<asp:Button ID="btnButtonNuevo" runat="server" CssClass="btn btn-primary" Text="+" OnClick="btnButtonNuevo_Click" /></h3> 
         <asp:GridView ID="GridViewParametro"  CssClass="table table-bordered" AutoGenerateColumns="False" runat="server" >
          <Columns>
                <asp:BoundField DataField="idTipoDocumento"  HeaderText="ID" Visible="true" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="Nombre"  HeaderText="Nombre" Visible="true" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="cRutaImagen"  HeaderText="Ruta de Imagen" Visible="true" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>               
                
                                <asp:TemplateField HeaderStyle-ForeColor="Black"  HeaderText="Opciones">
                    <ItemTemplate>
                         <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary" Text="Editar"  
                             OnClick="Editar"                            />
                     
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
