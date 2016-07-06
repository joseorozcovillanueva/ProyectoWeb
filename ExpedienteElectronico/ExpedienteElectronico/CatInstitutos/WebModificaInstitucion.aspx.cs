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
                TxtcNombre1.Text = txtcNombre.Text;
                txtcDireccion.Text = datos.Cells[2].Text;
                txtcDireccion1.Text = txtcDireccion.Text;
                txtcNombre.Attributes.Add("placeHolder", "Nombre del Instituto educativo");
                txtcDireccion.Attributes.Add("placeHolder", "Dirección del instituto educativo");
                txtcNombre.Focus();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                InstitucionNegocio institucionNegocio = new InstitucionNegocio();
                Institucion objInstitucion = new Institucion();
                Institucion obj = new Institucion();

                try
                {
                    objInstitucion.idInstitucion = Convert.ToInt32(lblID.Text);
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

                    if (TxtcNombre1.Text != objInstitucion.NombreInstitucion)
                    {
                        obj = institucionNegocio.obtenerInstitucion().Find(x => x.NombreInstitucion == objInstitucion.NombreInstitucion);
                        if (obj == null)
                        {
                            institucionNegocio.modificaInstitucion(objInstitucion);
                            Response.Redirect("WebInstitucion.aspx");
                        }
                        else
                        {
                            throw new Exception("Error ya existe ese nombre de institución");
                        }
                    }
                    else
                    {
                        institucionNegocio.modificaInstitucion(objInstitucion);
                        Response.Redirect("WebInstitucion.aspx");
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
        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebInstitucion.aspx");
        }
    }
}