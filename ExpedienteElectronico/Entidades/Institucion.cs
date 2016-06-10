using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Institucion
    {
        /// <summary>
        /// Creación de los campos de la clase de institución
        /// </summary>
        public int idInstitucion { get; set; }
        public string NombreInstitucion { get; set; }
        public string Direccion { get; set; }
        public DateTime fechaCreacion { get; set; }

        public bool lValido { get; set; }
        public bool cancelado { get; set; }

        /// <summary>
        /// Constructor de institución por default
        /// </summary>
        public Institucion() { }
    }
}
