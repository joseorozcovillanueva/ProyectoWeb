﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpedienteElectronico.CapturaExpediente
{
    public partial class WebCapturaExpediente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           // string cimagen = "../img/7.png";
          //  cimagen = "cargaImagen('" + cimagen + "');";
          ScriptManager.RegisterStartupScript(Page, Page.GetType(), "imagen", "cargaImagen();", true);
            imagen1.ImageUrl = "../img/7.png";
        }

        protected void rotate_left_Click(object sender, EventArgs e)
        {

        }

        protected void fit_Click(object sender, EventArgs e)
        {
            string cimagen = "../img/7.png";
            cimagen = "cargaImagen('" + cimagen + "');";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "imagen", "cargaImagen();", true);
            //   ScriptManager.RegisterStartupScript(Page, Page.GetType(), "imagen", "$('#imgbase').append(<img id=\'imgbase\'src\'I:/expedientes/Predio/20/0069/20-0069-0000260260/7.tif\')", true);
            //     append('<img id=\'miImagen\' src=\'/imagenes/yoda.png\' class=\'miClase\' />')
            //   ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#fit').click(function () { picture.guillotine('fit'); });", true);
        }
    }
}