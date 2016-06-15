using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Negocio
{
    public class ParametroNegocio
    {
        public int insertarParametro(Parametro _parametro)
        {
            ParametroDao dao = new ParametroDao();

            return dao.InsertaParametro(_parametro);
        }

        public List<Parametro> obtenerParametro()
        {
            ParametroDao dao = new ParametroDao();

            return dao.obtenerParametro();
        }

        public void modificaParametro(Parametro _parametro)
        {
            ParametroDao dao = new ParametroDao();

            dao.modificaParametro(_parametro);
        }

        public void eliminaParametro(Parametro _parametro)
        {
            ParametroDao dao = new ParametroDao();

            dao.eliminaParametro(_parametro);
        }
    }
}
