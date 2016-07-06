using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace WebExpedienteElectronico
{
    public partial class WebEliminarCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InstitucionNegocio _objneg = new InstitucionNegocio();

            if (!Page.IsPostBack)
            {
                ddlInstitucion.DataSource = _objneg.obtenerInstitucion();
                ddlInstitucion.DataValueField = "idInstitucion";
                ddlInstitucion.DataTextField = "NombreInstitucion";
                ddlInstitucion.DataBind();
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
                txtcNombre.Text = datos.Cells[1].Text;
                ddlInstitucion.Items.FindByValue(datos.Cells[2].Text.ToString()).Selected = true;
            }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                CarreraNegocio carrera = new CarreraNegocio();

                Carrera objCarrera = new Carrera();

                objCarrera.idCarrera = Convert.ToInt32(lblID.Text);
                objCarrera.Nombre = txtcNombre.Text;
                objCarrera.idInstit = Convert.ToInt32(ddlInstitucion.SelectedValue.ToString());

                carrera.eliminaCarrera(objCarrera);
                                
                Response.Redirect("WebCarrera.aspx");
            }
        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebCarrera.aspx");
        }
    }
}