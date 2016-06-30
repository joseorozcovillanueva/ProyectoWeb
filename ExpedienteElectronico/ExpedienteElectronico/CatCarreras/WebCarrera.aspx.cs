using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebEntidadesApp;
using WebNegociosApp;

namespace WebExpedienteElectronico
{
    public partial class WebCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                CarreraNegocio carreraNegocio = new CarreraNegocio();

                try
                {
                    GridViewCarrera.DataSource = carreraNegocio.obtenerCarrera();
                    GridViewCarrera.DataBind();

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
            Response.Redirect("WebModificaCarrera.aspx");
        }

        protected void Eliminar(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["gvr"] = gvr;
            Response.Redirect("WebEliminarCarrera.aspx");

        }
        protected void GridViewInsitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btnButtonNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebInsertarCarrera.aspx");
        }

        protected void GridViewCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}