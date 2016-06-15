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
    public partial class WebEliminaMunicipio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EstadoNegocio estadoNegocio = new EstadoNegocio();

            if (!Page.IsPostBack)
            {
                dropListEstado.DataSource = estadoNegocio.obtenerEstado();
                dropListEstado.DataValueField = "idEstado";
                dropListEstado.DataTextField = "Nombre";
                dropListEstado.DataBind();
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
                txtcNombre.Text = datos.Cells[2].Text;
                dropListEstado.Items.FindByValue(datos.Cells[1].Text.ToString()).Selected = true;
                txtcNombre.Attributes.Add("placeHolder", "Nombre del Municipio");                
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Municipio objMun = new Municipio();
                MunicipioNegocio municipioNegocio = new MunicipioNegocio();

                objMun.idEstado = Convert.ToInt32(dropListEstado.SelectedValue.ToString());
                objMun.Nombre = txtcNombre.Text.ToUpper();
                Session["ID"] = Convert.ToString(objMun.idEstado);
                municipioNegocio.eliminaMunicipio(objMun);
                Response.Redirect(Page.ResolveUrl("~/CatMunicipios/WebMunicipio.aspx"));
            }
        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect(Page.ResolveUrl("~/CatMunicipios/WebMunicipio.aspx"));
        }
    }
}