<%@ Page EnableEventValidation="true" Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="WebCarrera.aspx.cs" Inherits="WebExpedienteElectronico.WebCarrera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
     <br />
    <br />
    <br />
     <div class="col-xs-pull-7">
      
    <h3>Cátologo de Carreras <asp:Button ID="btnButtonNuevo" runat="server" CssClass="btn btn-primary" Text="+" OnClick="btnButtonNuevo_Click" /> </h3> 
         <asp:GridView ID="GridViewCarrera"  CssClass="table table-bordered" AutoGenerateColumns="False" runat="server" OnSelectedIndexChanged="GridViewCarrera_SelectedIndexChanged">
          <Columns>
                <asp:BoundField DataField="IdCarrera"  HeaderText="ID" Visible="true" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="Nombre"  HeaderText="Nombre de la Carrera" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="idInstit"  HeaderText="Id Institucion" >
                <ControlStyle CssClass="table table-bordered" />
                </asp:BoundField>
                <asp:BoundField DataField="FechaCreacion"  HeaderText="Fecha Creación" >
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
