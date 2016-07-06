using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ExpedienteElectronico
{
    public static class Mensajes
    {
        public static void Msjs(this Page _pagina, string cLlave, string _Mensaje)
        {
            _pagina.ClientScript.RegisterStartupScript(_pagina.GetType(), cLlave, "<script language='javascript'>alert('" + _Mensaje + "')</script>");
        }
    }
}