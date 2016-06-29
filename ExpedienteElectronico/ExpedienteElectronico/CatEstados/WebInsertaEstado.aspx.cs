using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace ExpedienteElectronico.CatEstados
{
    public partial class WebInsertaEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtcNombre.Attributes.Add("placeHolder", "Nombre del Estado");            
            txtcNombre.Focus();

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            EstadoNegocio estadoNegocio = new EstadoNegocio();
            Estado objNegocio = new Estado();
            Estado obj = new Estado();

            try
            {

                objNegocio.Nombre = txtcNombre.Text.ToUpper();
                if (txtcNombre.Text == "")
                {
                    throw new Exception("Error nombre del estado no puede estar en blanco");
                }

                obj = estadoNegocio.obtenerEstado().Find(x => x.Nombre == objNegocio.Nombre);
                if (obj == null)
                {
                    estadoNegocio.insertarEstado(objNegocio);
                    Response.Redirect("WebEstado.aspx");
                }
                else
                {
                    throw new Exception("Error ya existe ese nombre del estado");
                }
                
            }
            catch(Exception ex)
            {
                lblModalTitle.Text = "Validación";
                lblModalBody.Text = ex.Message;                
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "openModal();", true);
                
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebEstado.aspx");

        }
    }
}