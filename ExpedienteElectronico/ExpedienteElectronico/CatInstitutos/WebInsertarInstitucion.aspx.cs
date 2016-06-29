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

           


            Response.Redirect("WebInstitucion.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            
            //ClientScript.RegisterClientScriptBlock(this.GetType(), "myfunction", "$(document).ready(function(){showDialog('#myModal');});", true);
            //Response.Redirect("WebInstitucion.aspx");
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "openModal()", true);

        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            InstitucionNegocio institucionNegocio = new InstitucionNegocio();
            Institucion objInstitucion = new Institucion();
            Institucion obj = new Institucion();

            try
            {
                objInstitucion.NombreInstitucion = txtcNombre.Text;
                objInstitucion.Direccion = txtcDireccion.Text;

                if (txtcNombre.Text == "")
                {
                    throw new Exception("Error el nombre de la institución no puede estar en blanco");
                }
                if (txtcDireccion.Text == "")
                {
                    throw new Exception("Error la dirección de la institución no puede estar en blanco");
                }


                obj = institucionNegocio.obtenerInstitucion().Find(x => x.NombreInstitucion == objInstitucion.NombreInstitucion);
                if (obj == null)
                {
                    institucionNegocio.insertarInstitucion(objInstitucion);
                    Response.Redirect("WebInstitucion.aspx");
                }                
                else
                {
                    throw new Exception("Error ya existe ese nombre de institución");
                }                
            }
            catch (Exception ex)
            {
                                
                lblModalTitle.Text = "Validación";
                lblModalBody.Text = ex.Message;
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                //string mensaje = "mensaje(" + "'Error en el nombre de la institucion'" + ");";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "openModal();", true);
                //upModal.Update();
            }

           
        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebInstitucion.aspx");
            //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "openModal()", true);
            //string mensaje = "mensaje(" + "'Error en el nombre de la institucion'" + ");";
            
        }

        protected void linkButton_Click(object sender, EventArgs e)
        {

        }
    }
}