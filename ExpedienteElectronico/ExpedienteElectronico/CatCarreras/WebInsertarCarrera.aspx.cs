using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNegociosApp;
using WebEntidadesApp;

namespace WebExpedienteElectronico
{
    public partial class WebInsertarCarrera : System.Web.UI.Page
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
                /* GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;  */
                //dropListServicio.Items.FindByValue(datos.Cells[1].Text.ToString()).Selected = true;
                /*txtObservaciones.Text = datos.Cells[3].Text; */ 
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            if(Page.IsPostBack)
            {
                ServicioEquipoComputoNegocio servicioequiponeg = new ServicioEquipoComputoNegocio();
                ServicioEquipoComputo servicioequipo = new ServicioEquipoComputo();
                servicioequipo.iIdServicioEquipoComputo = Convert.ToInt32(lblID.Text);
                servicioequipo.iIdServicio = Convert.ToInt32(dropListServicio.SelectedValue.ToString());
                servicioequipo.tDescripcion = txtObservaciones.Text;
                servicioequiponeg.modificaServicioEC(servicioequipo);
                Response.Redirect(Page.ResolveUrl("~/GestionEquipos/Servicios/VerServiciosEquipo.aspx"));
            }
            */

            CarreraNegocio carrera = new CarreraNegocio();
            Carrera objCarrera = new Carrera();

            List<Carrera> lstCarreras = new List<Carrera>();

            Boolean bInsertar = true;

            objCarrera.Nombre = txtcNombre.Text;
            objCarrera.idInstit = Convert.ToInt32(ddlInstitucion.SelectedValue.ToString());

            lstCarreras  = carrera.obtenerCarrera();

            foreach (Carrera nombrecarrera in lstCarreras)
            {
                try {
                    if (nombrecarrera.Nombre == objCarrera.Nombre)
                    {
                        bInsertar = false;
                        throw new Exception("Ya existe una carrera con ese nombre.");
                    }
                }
                catch (Exception ex)
                {
                    /*Response.Write("<script LANGUAGE='JavaScript' >alert('Login Successful')</script>");*/
                    /*this.Page.Response.Write("<script language='JavaScript'>window.alert('" + ex.Message + "');</script>");*/

                    /* Console.WriteLine(ex.Message); */
                }                
            }

            if (bInsertar == true) carrera.insertaCarrera(objCarrera);



            Response.Redirect("WebCarrera.aspx");
        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebCarrera.aspx");
        }

        protected void ddlInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}