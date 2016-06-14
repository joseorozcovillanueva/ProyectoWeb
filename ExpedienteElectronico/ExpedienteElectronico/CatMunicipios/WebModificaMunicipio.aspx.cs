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
    public partial class WebModificaMunicipio : System.Web.UI.Page
    {
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                dropListEstado.DataSource = estadoNegocio.obtenerEstado();
                dropListEstado.DataValueField = "idEstado";
                dropListEstado.DataTextField = "Nombre";
                dropListEstado.DataBind();
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
                dropListEstado.Items.FindByValue(datos.Cells[1].Text.ToString()).Selected = true;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Municipio objMun = new Municipio();
                MunicipioNegocio municipioNegocio = new MunicipioNegocio();

                objMun.idEstado = Convert.ToInt32(dropListEstado.SelectedValue.ToString());
                objMun.Nombre = txtcNombre.Text;
                Session["ID"] = lblID.Text;
                municipioNegocio.modificaMunicipio(objMun);
                Response.Redirect(Page.ResolveUrl("~/CatMunicipios/WebMunicipio.aspx"));
            }
        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}