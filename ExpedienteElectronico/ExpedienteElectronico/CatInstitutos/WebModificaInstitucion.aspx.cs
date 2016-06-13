using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace ExpedienteElectronico.CatInstitutos
{
    public partial class WebModificaInstitucion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
                txtcNombre.Text = datos.Cells[1].Text;
                txtcDireccion.Text = datos.Cells[2].Text;

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                InstitucionNegocio institucionNegocio = new InstitucionNegocio();
                Institucion objInstitucion = new Institucion();


                objInstitucion.idInstitucion = Convert.ToInt32(lblID.Text);
                objInstitucion.NombreInstitucion = txtcNombre.Text;
                objInstitucion.Direccion = txtcDireccion.Text;
                institucionNegocio.modificaInstitucion(objInstitucion);

                Response.Redirect("WebInstitucion.aspx");
            }
        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebInstitucion.aspx");
        }
    }
}