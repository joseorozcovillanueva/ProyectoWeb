using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace ExpedienteElectronico.CatEstados
{
    public partial class WebEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                EstadoNegocio estadoNegocio = new EstadoNegocio();

                try
                {
                    GridViewEstado.DataSource = estadoNegocio.obtenerEstado();
                    GridViewEstado.DataBind();

                }
                catch (Exception ex)
                {
                    throw new Exception("error de la consulta" + ex.Message);

                }

            }
        }
        protected void Editar(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["gvr"] = gvr;
            Response.Redirect("WebModificaEstado.aspx");
        }

        protected void Eliminar(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["gvr"] = gvr;
            Response.Redirect("WebEliminaEstado.aspx");

        }
        protected void AgrMunicipio(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["gvr"] = gvr;            
            Session["ID"] = gvr.Cells[0].Text;             
            Response.Redirect(Page.ResolveUrl("~/CatMunicipios/WebMunicipio.aspx"));
        }

        protected void btnButtonNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebInsertaEstado.aspx");
        }
    }
}