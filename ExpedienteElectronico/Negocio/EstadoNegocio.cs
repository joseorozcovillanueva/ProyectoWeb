using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Negocio
{
    public class EstadoNegocio
    {
        public int insertarEstado(Estado _estado)
        {
            EstadoDao dao = new EstadoDao();

            return dao.InsertaEstado(_estado);
        }

        public List<Estado> obtenerEstado()
        {
            EstadoDao dao = new EstadoDao();

            return dao.obtenerEstado();
        }

        public void modificaEstado(Estado _estado)
        {
            EstadoDao dao = new EstadoDao();

            dao.modificaEstado(_estado);
        }

        public void eliminaEstado(Estado _estado)
        {
            EstadoDao dao = new EstadoDao();

            dao.eliminaEstado(_estado);
        }
    }
}
