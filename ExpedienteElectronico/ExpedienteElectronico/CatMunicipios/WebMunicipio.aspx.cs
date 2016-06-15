using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace ExpedienteElectronico.CatMunicipios
{
    public partial class WebMunicipio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MunicipioNegocio negocioMunicipio = new MunicipioNegocio();
            EstadoNegocio negocioEstado = new EstadoNegocio();
            Estado objEstado = new Estado();

            if (Session["ID"] == null)
            {
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
            }
            else
            {
                lblID.Text = Session["ID"] as string;
            }

            try
            {
                int idEstado = Convert.ToInt32(lblID.Text.ToString());
                objEstado = negocioEstado.obtenerEstado().Find(x => x.idEstado == idEstado);

                lblNombreEstado.Text = objEstado.Nombre;

                GridViewMunicipio.DataSource = negocioMunicipio.obtenerMunicipio(idEstado);
                GridViewMunicipio.DataBind();

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta" + ex.Message);

            }

        }

        protected void btnButtonNuevo_Click(object sender, EventArgs e)
        {
            Session["ID"] = lblID.Text;
            Response.Redirect(Page.ResolveUrl("WebInsertaMunicipio.aspx"));
        }
        protected void Editar(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["gvr"] = gvr;
            Session["ID"] = lblID.Text;
            Response.Redirect("WebModificaMunicipio.aspx");
        }

        protected void Eliminar(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["gvr"] = gvr;
            Session["ID"] = lblID.Text;
            //Response.Redirect("WebEliminaEstado.aspx");

        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect(Page.ResolveUrl("~/CatEstados/WebEstado.aspx"));
        }
    }


}