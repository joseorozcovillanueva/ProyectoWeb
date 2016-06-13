using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Municipio
    {
        /// <summary>
        /// Creación de la entidad del catálogo de municipio
        /// </summary>
        public int idMunicipio { get; set; }
        public int idEstado { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Cancelado { get; set; }

        /// <summary>
        /// Constructor default de la clase municipio
        /// </summary>
        public Municipio() { }
    }
}
