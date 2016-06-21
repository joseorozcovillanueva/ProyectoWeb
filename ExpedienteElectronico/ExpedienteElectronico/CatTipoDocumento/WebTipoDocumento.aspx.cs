using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpedienteElectronico.CatTipoDocumento
{
    public partial class WebTipoDocumento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnButtonNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebInsertaTipoDocumento.aspx");
        }
    }
}