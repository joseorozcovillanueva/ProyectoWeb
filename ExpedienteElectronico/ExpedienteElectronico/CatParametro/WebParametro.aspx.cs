using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace ExpedienteElectronico.CatParametro
{
    public partial class WebParametro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ParametroNegocio parametroNegocio = new ParametroNegocio();

                try
                {
                    GridViewParametro.DataSource = parametroNegocio.obtenerParametro();
                    GridViewParametro.DataBind();

                }
                catch (Exception ex)
                {
                    throw new Exception("error de la consulta" + ex.Message);

                }

            }
        }

        protected void btnButtonNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebInsertaParametro.aspx");
        }
        protected void Editar(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["gvr"] = gvr;
            Response.Redirect("WebModificaParametro.aspx");
        }

        protected void Eliminar(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["gvr"] = gvr;
            Response.Redirect("WebEliminaParametro.aspx");

        }
    }
}