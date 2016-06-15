using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auditoria
    {
        /// <summary>
        /// Creación de la entidad de auditoria
        /// </summary>
        public int idAuditoria { get; set; }
        public string cNombreMaquina { get; set; }
        public DateTime dtFechaOperacion { get; set; }
        public int idUsuario { get; set; }
        public string cIPMaquina { get; set; }
        public string cOperacion { get; set; }
        public string cValor { get; set; }

        /// <summary>
        /// Constructor default
        /// </summary>
        public Auditoria() { }

    }
}
