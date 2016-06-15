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
            EstadoNegocio estadoNegocio = new EstadoNegocio();

            if (!Page.IsPostBack)
            {
                dropListEstado.DataSource = estadoNegocio.obtenerEstado();
                dropListEstado.DataValueField = "idEstado";
                dropListEstado.DataTextField = "Nombre";
                dropListEstado.DataBind();
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
                string idEstado = Session["ID"] as string;
                dropListEstado.Items.FindByValue(idEstado).Selected = true;
                txtcNombre.Attributes.Add("placeHolder", "Nombre del Municipio");
                txtcNombre.Focus();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Municipio objMun = new Municipio();
            MunicipioNegocio municipioNegocio = new MunicipioNegocio();

            objMun.idEstado = Convert.ToInt32(dropListEstado.SelectedValue.ToString());
            objMun.Nombre = txtcNombre.Text.ToUpper();
            Session["ID"] = Convert.ToString(objMun.idEstado);
            municipioNegocio.insertarMunicipio(objMun);
            Response.Redirect(Page.ResolveUrl("~/CatMunicipios/WebMunicipio.aspx"));

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect(Page.ResolveUrl("~/CatMunicipios/WebMunicipio.aspx"));
        }
    }
}