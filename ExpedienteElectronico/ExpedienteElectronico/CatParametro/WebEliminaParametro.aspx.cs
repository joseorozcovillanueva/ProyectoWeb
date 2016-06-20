using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace ExpedienteElectronico.CatParametro
{
    public partial class WebEliminaParametro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
                txtcNombre.Text = datos.Cells[1].Text;
                txtcDescripcion.Text = datos.Cells[2].Text;
                txtcValor.Text = datos.Cells[3].Text;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                ParametroNegocio negocioParametro = new ParametroNegocio();
                Parametro objParametro = new Parametro();

                objParametro.idParametro = Convert.ToInt32(lblID.Text);
                objParametro.cNombre = txtcNombre.Text;
                objParametro.cValor = txtcValor.Text;
                objParametro.cDescripcion = txtcDescripcion.Text;

                negocioParametro.eliminaParametro(objParametro);
                Response.Redirect("WebParametro.aspx");

            }

        }
        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebParametro.aspx");
        }
    }
}