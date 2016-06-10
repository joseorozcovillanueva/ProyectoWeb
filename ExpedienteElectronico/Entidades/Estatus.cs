using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estatus
    {
        /// <summary>
        /// Creacion de los campos de la clase de estatus
        /// </summary>
        public int idEstatus { get; set; }
        public string nombre { get; set; }
        public string siglas { get; set; }
        public string etiqueta { get; set; }
        public string proceso { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public bool cancelado { get; set; }

        /// <summary>
        /// Creacion del constructor de la clase estatus
        /// </summary>
        public Estatus() { }
    }
}
