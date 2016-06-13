<%@ Page EnableEventValidation="true" Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebEstado.aspx.cs" Inherits="ExpedienteElectronico.CatEstados.WebEstado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="container">
      
    <h3>Cátologo de Estados <asp:Button ID="btnButtonNuevo" runat="server" CssClass="btn btn-primary" Text="+" OnClick="btnButtonNuevo_Click" /> </h3> 
         <asp:GridView ID="GridViewEstado"  CssClass="table table-bordered" AutoGenerateColumns="False" runat="server" >
          <Columns>
                <asp:BoundField DataField="idEstado"  HeaderText="ID" Visible="true" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                
                <asp:BoundField DataField="Nombre"  HeaderText="Nombre Municipio" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaCreacion"  HeaderText="Fecha Creacion" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="Fecha Modificacion"  HeaderText="Fecha Modificacion" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                                <asp:TemplateField HeaderStyle-ForeColor="Black"  HeaderText="Opciones">
                    <ItemTemplate>
                        <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary" Text="Editar"  
                             OnClick="Editar"
                             />

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
