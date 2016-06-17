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
    public partial class WebInsertaParametro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtcNombre.Attributes.Add("placeHolder", "Nombre del parametro");
            txtcDescripcion.Attributes.Add("placeHolder", "Descripción del parametro");
            txtcValor.Attributes.Add("placeHolder", "Valor del parametro");
            txtcNombre.Focus();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ParametroNegocio parametroNegocio = new ParametroNegocio();

            Parametro objParametro = new Parametro();

            objParametro.cDescripcion = txtcDescripcion.Text.ToUpper();
            objParametro.cNombre = txtcNombre.Text.ToUpper();
            objParametro.cValor = txtcValor.Text.ToUpper();

            parametroNegocio.insertarParametro(objParametro);

            Response.Redirect("WebParametro.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebParametro.aspx");
        }
    }
}