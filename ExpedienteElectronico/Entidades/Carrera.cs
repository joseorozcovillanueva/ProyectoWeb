using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEntidadesApp
{
    public class Carrera
    {
        /// <summary>
        /// Creación de los campos de la clase carrera
        /// </summary>
        public int idCarrera { get; set; }
        public string Nombre { get; set; }
        public DateTime fechaCreacion { get; set; }

        public DateTime fechaModificacion { get; set; }

        public bool cancelado { get; set; }

        public int idInstit { get; set; }

        public bool lValid { get; set; }

        /// <summary>
        /// Constructor de la clase carrera
        /// </summary>
        public Carrera() { }
    }
}
