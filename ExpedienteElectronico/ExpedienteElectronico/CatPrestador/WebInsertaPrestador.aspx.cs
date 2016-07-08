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
    public partial class WebInsertaPrestador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            CargaEstado();
           /* if (!Page.IsPostBack)
            {
                EstadoNegocio objEdoBE = new EstadoNegocio();
                DropListEstado.DataSource = objEdoBE.obtenerEstado();
                
                DropListEstado.DataValueField = "idEstado";
                DropListEstado.DataTextField = "Nombre";
                DropListEstado.DataBind();
            }*/

         }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Mensajes.Msjs(this, "Error", "AfectaTODO");
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
                                        if (string.IsNullOrEmpty(txtEmail.Text))
                                        {
                                            Mensajes.Msjs(this, "Error", "El correo es obligatorio");
                                            txtMatricula.Focus();
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(txtPass.Text))
                                            {
                                                Mensajes.Msjs(this, "Error", "El password  es obligatorio");
                                                txtMatricula.Focus();
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty(txtConfpass.Text))
                                                {
                                                    Mensajes.Msjs(this, "Error", "Favor de confirmar el password");
                                                    txtMatricula.Focus();
                                                }
                                                else
                                                {
                                                    if (txtPass.Text != txtConfpass.Text)
                                                    {
                                                        Mensajes.Msjs(this, "Error", "No coicide la confirmacion del password");
                                                        txtConfpass.Focus();
                                                    }
                                                    else
                                                    {

                                                        int idDocumento = 0;
                                                        Prestador objPrest = new Prestador();
                                                        PrestadorNegocio objPresBE = new PrestadorNegocio();
                                                        objPrest.Nombre = txtcNombrePrestador.Text;
                                                        objPrest.ApellidoPat = TxtApellido.Text;
                                                        objPrest.ApellidoMat = txtApellidoMat.Text;
                                                        objPrest.domicilio = txtDireccion.Text;
                                                        objPrest.celular = txtTel.Text;
                                                        objPrest.Matricula = Convert.ToInt32(txtMatricula.Text);
                                                        objPrest.eMail = txtEmail.Text;
                                                        objPrest.password = txtConfpass.Text;
                                                        objPrest.idEstado = Convert.ToInt32(DropListEstado.SelectedValue.ToString());
                                                        objPrest.idMunicipio = Convert.ToInt32(dropListMunicipio.SelectedValue.ToString());
                                                        //objPrest.idInstitucion = Convert.ToInt32(DropListInst.SelectedValue.ToString());
                                                        //objPrest.idCarrera = Convert.ToInt32(DropListCarrera.SelectedValue.ToString());
                                                        
                                                        idDocumento = objPresBE.CrearPrestador(objPrest);
                                                        Mensajes.Msjs(this, "Mensaje", "Registro guardado exitosamente");
                                                        Response.Redirect(Page.ResolveUrl("~/Default.aspx"));
                                                    }
                                                }
                                                }
                                        }
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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Mensajes.Msjs(this, "Error", "CancelaTODO");
        }
        protected void CargaEstado()
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    EstadoNegocio objEdoBE = new EstadoNegocio();
                    DropListEstado.DataSource = objEdoBE.obtenerEstado();
                    DropListEstado.DataValueField = "idEstado";
                    DropListEstado.DataTextField = "Nombre";
                    DropListEstado.DataBind();

                    MunicipioNegocio objMunBE = new MunicipioNegocio();
                    dropListMunicipio.DataSource = objMunBE.obtenerMunicipio(1);
                    dropListMunicipio.DataValueField = "idMunicipio";
                    dropListMunicipio.DataTextField = "Nombre";
                    dropListMunicipio.DataBind();

                    InstitucionNegocio objInsBE = new InstitucionNegocio();
                    DropListInst.DataSource = objInsBE.obtenerInstitucion();
                    DropListInst.DataValueField = "idInstitucion";
                    DropListInst.DataTextField = "NombreInstitucion";
                    DropListInst.DataBind();

                   /* CarreraNegocio objCarBE = new CarreraNegocio();
                    DropListCarrera.DataSource = objCarBE.ConsultaInsenCarrera(Convert.ToInt32(DropListInst.SelectedValue.ToString()));
                    DropListCarrera.DataValueField = "idCarrera";
                    DropListCarrera.DataTextField = "Nombre";
                    DropListCarrera.DataBind(); */


                }



            }
            catch (Exception ex)
            {
                Mensajes.Msjs(this, "Error", "Ocurrió el siguiente detalle: " + ex.Message);
            }
        }

        
        
    }
}