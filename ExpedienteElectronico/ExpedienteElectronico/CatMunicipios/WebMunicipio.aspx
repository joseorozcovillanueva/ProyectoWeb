<%@ Page EnableEventValidation="true" Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebMunicipio.aspx.cs" Inherits="ExpedienteElectronico.CatMunicipios.WebMunicipio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container">
      
    <h3><asp:Button ID="regresar" runat="server" Text="Regresar" CssClass="btn btn-primary" OnClick="regresar_Click" />&nbsp;&nbsp;| Catálogo de Municipios | Del Estado <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>&nbsp;<asp:Label ID="lblNombreEstado" runat="server"></asp:Label> &nbsp;<asp:Button ID="btnButtonNuevo" runat="server" CssClass="btn btn-primary" Text="+" OnClick="btnButtonNuevo_Click" /></h3> 
         <asp:GridView ID="GridViewMunicipio"  CssClass="table table-bordered" AutoGenerateColumns="False" runat="server" >
          <Columns>
                <asp:BoundField DataField="idMunicipio"  HeaderText="ID" Visible="true" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="idEstado"  HeaderText="ID Estado" Visible="true" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>

                <asp:BoundField DataField="Nombre"  HeaderText="Nombre Municipio" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaCreacion"  HeaderText="Fecha Creacion" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaModificacion"  HeaderText="Fecha Modificacion" >
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
