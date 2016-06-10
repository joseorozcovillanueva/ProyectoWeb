using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestador
    {
        /// <summary>
        /// Creación de los campos de la clase Prestador
        /// </summary>
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public string celular { get; set; }
        public string eMail { get; set; }
        public string domicilio { get; set; }
        public string password { get; set; }
        public Institucion idInstitucion { get; set; }
        public Carrera idCarrera { get; set; }
        public int horasAsignadas { get; set; }
        public int Matricula { get; set; }
        public Estatus idEstatusAutorizados { get; set; }
        public Estatus idEstatusActivo { get; set; }

        /// <summary>
        /// Creación del constructor de la clase prestador
        /// </summary>
        public Prestador() { }
    }
}
