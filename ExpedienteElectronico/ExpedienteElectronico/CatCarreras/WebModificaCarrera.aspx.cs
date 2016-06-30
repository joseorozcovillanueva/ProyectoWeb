using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebEntidadesApp;
using WebNegociosApp;

namespace WebExpedienteElectronico
{
    public partial class WebModificaCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InstitucionNegocio _objneg = new InstitucionNegocio();
            CarreraNegocio carreraNeg = new CarreraNegocio();
            Carrera objCarrera = new Carrera();

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

                objCarrera = carreraNeg.buscaCarrera(Convert.ToInt32(datos.Cells[0].Text), Convert.ToInt32(datos.Cells[2].Text));
                if (objCarrera.cancelado == true) { chbCancelado.Checked = true; }                                    
                else chbCancelado.Checked = false;
                
                if (objCarrera.lValid == true) { chbValido.Checked = true; }
                else chbValido.Checked = false;
                
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            /*if (Page.IsPostBack)
            {

                InstitucionNegocio institucionNegocio = new InstitucionNegocio();
                Institucion objInstitucion = new Institucion();


                objInstitucion.idInstitucion = Convert.ToInt32(lblID.Text);
                objInstitucion.NombreInstitucion = txtcNombre.Text;
                objInstitucion.Direccion = txtcDireccion.Text;
                institucionNegocio.modificaInstitucion(objInstitucion);

                Response.Redirect("WebCarrera.aspx");
            }*/
            CarreraNegocio carrera = new CarreraNegocio();

            Carrera objCarrera = new Carrera();

            List<Carrera> lstCarreras = new List<Carrera>();
            Boolean bInsertar = true;

            objCarrera.idCarrera = Convert.ToInt32(lblID.Text);
            objCarrera.Nombre = txtcNombre.Text;
            objCarrera.idInstit = Convert.ToInt32(ddlInstitucion.SelectedValue.ToString());
            if (chbCancelado.Checked) { objCarrera.cancelado = true; }
            else objCarrera.cancelado = false;

            if (chbValido.Checked) { objCarrera.lValid = true; }
            else objCarrera.lValid = false;

            foreach (Carrera nombrecarrera in lstCarreras)
            {
                try
                {
                    if ( (nombrecarrera.Nombre == objCarrera.Nombre) && (objCarrera.idCarrera != nombrecarrera.idCarrera))
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

            /* carrera.insertaCarrera(objCarrera); */
            Response.Redirect("WebCarrera.aspx");
        }

        protected void btnButtonCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebCarrera.aspx");
        }
    }
}