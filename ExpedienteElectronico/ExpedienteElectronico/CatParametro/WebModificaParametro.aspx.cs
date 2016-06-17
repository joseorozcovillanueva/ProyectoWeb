using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace ExpedienteElectronico.CatParametro
{
    public partial class WebModificaParametro : System.Web.UI.Page
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

                txtcNombre.Attributes.Add("placeHolder", "Nombre del parametro");
                txtcDescripcion.Attributes.Add("placeHolder", "Descripción del parametro");
                txtcValor.Attributes.Add("placeHolder", "Valor del parametro");
                txtcDescripcion.Focus();
            }

        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebParametro.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                ParametroNegocio parametroNegocio = new ParametroNegocio();
                Parametro objparametro = new Parametro();


                objparametro.idParametro = Convert.ToInt32(lblID.Text);
                objparametro.cNombre = txtcNombre.Text.ToUpper();
                objparametro.cDescripcion = txtcDescripcion.Text.ToUpper();
                objparametro.cValor = txtcValor.Text.ToUpper();

                parametroNegocio.modificaParametro(objparametro);

                Response.Redirect("WebParametro.aspx");
            }
        }
    }
}