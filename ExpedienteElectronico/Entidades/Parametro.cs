using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Parametro
    {
        /// <summary>
        ///  Creación de la entidad de parametro
        /// </summary>
        public int idParametro { get; set; }
        public string cDescripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string cValor { get; set; }
        public bool lCancelado { get; set; }

        /// <summary>
        /// Constructor default de la entidad parametro
        /// </summary>
        public Parametro() { }
    }
}
