using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;
using System.Web.Security;
using System.Data;

namespace ExpedienteElectronico.CatPrestador
{
    public partial class InsertarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //txtcNombrePrestador.Focus();

            //EstadoNegocio estadoNegocio = new EstadoNegocio();
            /*
            MunicipioNegocio MunipioBS = new MunicipioNegocio();
            if (!Page.IsPostBack)
            {
                int idclave = 0;
                dropListMunicipio.DataSource = MunipioBS.obtenerMunicipio(idclave);
                dropListMunicipio.DataValueField = "idMunicipio";
                dropListMunicipio.DataTextField = "Nombre";
                dropListMunicipio.DataBind();
                GridViewRow datos = (GridViewRow)Session["gvr"];
                lblID.Text = datos.Cells[0].Text;
                string idMunicipio = Session["ID"] as string;
                dropListMunicipio.Items.FindByValue(idMunicipio).Selected = true;
                txtcNombre.Attributes.Add("placeHolder", "Nombre del Municipio");
                txtcNombre.Focus(); 
            } */

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Mensajes.Msjs(this, "Error", "GuardaTODO");
            try
            {
                if (string.IsNullOrEmpty(txtcNombrePrestador.Text))
                {
                    Mensajes.Msjs(this, "Error", "El nombre es obligatorio");
                    txtcNombrePrestador.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(TxtApellido.Text))
                    {
                        Mensajes.Msjs(this, "Error", "El apellido paterno es obligatorio");
                        TxtApellido.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtApellidoMat.Text))
                        {
                            Mensajes.Msjs(this, "Error", "El apellido materno es obligatorio");
                            txtApellidoMat.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtDireccion.Text))
                            {
                                Mensajes.Msjs(this, "Error", "La dirección es obligatorio");
                                txtDireccion.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtTel.Text))
                                {
                                    Mensajes.Msjs(this, "Error", "El telefono es obligatorio");
                                    txtTel.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txtMatricula.Text))
                                    {
                                        Mensajes.Msjs(this, "Error", "La matricula  es obligatorio");
                                        txtMatricula.Focus();
                                    }
                                    else
                                    {
                                        


                                        /*
                                        int idDocumento = 0;

                                        ProveedorInfo oDocumento = new ProveedorInfo();
                                        ProveedorBE oDocumentoBE = new ProveedorBE();

                                        oDocumento.cNombre = txtNombre.Text;
                                        oDocumento.cApellidoPaterno = txtApPaterno.Text;
                                        oDocumento.cApellidoMaterno = txtApMaterno.Text;
                                        oDocumento.cDireccion = txtDireccion.Text;
                                        oDocumento.cRFC = txtRfc.Text;
                                        oDocumento.cCorreo = txtCorreo.Text;
                                        oDocumento.cObservaciones = txtObservaciones.Text;
                                        oDocumento.dtFechaAlta = DateTime.Now;
                                        oDocumento.lActivo = true;
                                        Mensajes.Msjs(this, "Mensaje", oDocumento.cNombre);
                                        if (txtClaveProv.Text == "")
                                        {
                                            idDocumento = oDocumentoBE.Insertar(oDocumento);
                                            txtClaveProv.Text = Convert.ToString(idDocumento);
                                            oDocumento.iIdProveedor = idDocumento;
                                            Mensajes.Msjs(this, "Mensaje", "Registro guardado exitosamente");
                                        }
                                        else
                                        {
                                            oDocumento.iIdProveedor = Convert.ToInt32(txtClaveProv.Text);
                                            //Actualizacion
                                            oDocumentoBE.Actualizacion(oDocumento);
                                            Mensajes.Msjs(this, "Mensaje", "Registro se actualizo exitosamente");

                                        }


                                        GridConsulta.DataSource = oDocumentoBE.bsqClaveProve(oDocumento);
                                        GridConsulta.DataBind();

                                        btnCons.Enabled = true;
                                        btnGuardar.Enabled = false;


                                        txtClaveProv.Text = "";
                                        txtNombre.Text = "";
                                        txtApPaterno.Text = "";
                                        txtApMaterno.Text = "";
                                        txtDireccion.Text = "";
                                        txtRfc.Text = "";
                                        txtCorreo.Text = "";
                                        txtObservaciones.Text = ""; */



                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensajes.Msjs(this, "Error", "Ocurrió el siguiente detalle: " + ex.Message);
            }
        }
    }
}