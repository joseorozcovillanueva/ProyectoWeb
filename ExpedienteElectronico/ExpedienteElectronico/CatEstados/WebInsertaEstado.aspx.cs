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

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            EstadoNegocio estadoNegocio = new EstadoNegocio();

            Estado objNegocio = new Estado();

            objNegocio.Nombre = txtcNombre.Text;

            estadoNegocio.insertarEstado(objNegocio);

            Response.Redirect("WebEstado.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebEstado.aspx");

        }
    }
}