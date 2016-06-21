using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoDocumento
    {
        /// <summary>
        /// Creación de la entidad tipo de documento
        /// </summary>
        public int idTipoDocumento { get; set; }
        public string Nombre { get; set; }
        public DateTime dtFechaCreacion { get; set; }
        public DateTime dtFechaModificacion { get; set; }
        public string cRutaImagen { get; set; }
        public bool lCancelado { get; set; }

        /// <summary>
        /// Creación del constructor default de tipo de documento
        /// </summary>
        public TipoDocumento() { }
    }
}
