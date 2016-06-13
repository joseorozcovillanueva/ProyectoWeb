using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estado
    {
        /// <summary>
        /// Creación de la entidad del catálgo Estado
        /// </summary>
        public int idEstado { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Cancelado { get; set; }

        /// <summary>
        /// Constructor default de la clase municipio
        /// </summary>
        public Estado() { }

    }
}
