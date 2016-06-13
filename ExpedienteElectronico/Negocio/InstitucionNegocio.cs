using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Negocio
{
    public class InstitucionNegocio
    {
        public int insertarInstitucion(Institucion _institucion)
        {
            InstitucionDao dao = new InstitucionDao();

            return dao.InsertaInstitucion(_institucion);
        }

        public List<Institucion> obtenerInstitucion()
        {
            InstitucionDao dao = new InstitucionDao();

            return dao.obtenerInstitucion();
        }

        public void modificaInstitucion(Institucion _institucion)
        {
            InstitucionDao institucionDao = new InstitucionDao();

            institucionDao.modificaInstitucion(_institucion);
        }

        public void eliminaInstitucion(Institucion _institucion)
        {
            InstitucionDao institucionDao = new InstitucionDao();

            institucionDao.eliminaInstitucion(_institucion);
        }
    }
}
