using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace ExpedienteElectronico.CatMunicipios
{
    public partial class WebMunicipio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MunicipioNegocio negocioMunicipio = new MunicipioNegocio();

            if (Session["ID"] == null)
            {
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
            }
            else
            {
                lblID.Text = Session["ID"] as string;
            }

            try
            {
                int idEstado = Convert.ToInt32(lblID.Text.ToString());
                GridViewMunicipio.DataSource = negocioMunicipio.obtenerMunicipio(idEstado);
                GridViewMunicipio.DataBind();

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta" + ex.Message);

            }

        }

        protected void btnButtonNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebInsertaEstado.aspx");
        }
    }


}