using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {
        /// <summary>
        /// Creación de los campos de la clase carrera
        /// </summary>
        public int idCarrera { get; set; }
        public string Nombre { get; set; }
        public DateTime fechaCreacion { get; set; }
        public bool lValido { get; set; }
        public bool cancelado { get; set; }

        /// <summary>
        /// Constructor default la clase carrera
        /// </summary>
        public Carrera() { }
    }
}
