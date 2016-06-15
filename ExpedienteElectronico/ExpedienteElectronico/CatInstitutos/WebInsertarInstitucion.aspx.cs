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
    public partial class WebInsertarInstitucion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtcNombre.Attributes.Add("placeHolder", "Nombre del Instituto educativo");
            txtcDireccion.Attributes.Add("placeHolder", "Dirección del instituto educativo");
            txtcNombre.Focus();
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            InstitucionNegocio institucionNegocio = new InstitucionNegocio();

            Institucion objInstitucion = new Institucion();

            objInstitucion.NombreInstitucion = txtcNombre.Text;
            objInstitucion.Direccion = txtcDireccion.Text;

            institucionNegocio.insertarInstitucion(objInstitucion);


            Response.Redirect("WebInstitucion.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {        
            Response.Redirect("WebInstitucion.aspx");
        
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            InstitucionNegocio institucionNegocio = new InstitucionNegocio();

            Institucion objInstitucion = new Institucion();

            objInstitucion.NombreInstitucion = txtcNombre.Text;
            objInstitucion.Direccion = txtcDireccion.Text;

            institucionNegocio.insertarInstitucion(objInstitucion);

            Response.Redirect("WebInstitucion.aspx");
        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebInstitucion.aspx");
        }
    }
}