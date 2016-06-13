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
    public partial class WebModificaEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
                txtcNombre.Text = datos.Cells[1].Text;                

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                EstadoNegocio EstadoNegocio = new EstadoNegocio();
                Estado objEstado = new Estado();


                objEstado.idEstado = Convert.ToInt32(lblID.Text);
                objEstado.Nombre = txtcNombre.Text;
                EstadoNegocio.modificaEstado(objEstado);

                Response.Redirect("WebEstado.aspx");
            }
        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebEstado.aspx");
        }
    }
}