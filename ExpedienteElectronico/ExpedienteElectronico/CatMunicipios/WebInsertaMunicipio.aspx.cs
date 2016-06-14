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
    public partial class WebInsertaMunicipio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MunicipioNegocio negocioMunicipio = new MunicipioNegocio();
            EstadoNegocio negocioEstado = new EstadoNegocio();
            if (!Page.IsPostBack)
            {
                dropListEstado.DataSource = negocioEstado.obtenerEstado();
                dropListEstado.DataValueField = "idEstado";
                dropListEstado.DataTextField = "Nombre";
                dropListEstado.DataBind();
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            MunicipioNegocio negocioMunicipio = new MunicipioNegocio();
            Municipio objMuncipio = new Municipio();

            objMuncipio.idEstado = Convert.ToInt32(dropListEstado.SelectedValue.ToString());
            objMuncipio.Nombre = txtcNombre.Text;

            negocioMunicipio.insertarMunicipio(objMuncipio);

            Response.Redirect(Page.ResolveUrl("~/CatMunicipios/WebMunicipio.aspx"));

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect(Page.ResolveUrl("~/CatMunicipios/WebMunicipio.aspx"));
        }
    }
}