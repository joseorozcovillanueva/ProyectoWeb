using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Negocio
{
    public class MunicipioNegocio
    {
        public int insertarMunicipio(Municipio _municipio)
        {
            MunicipioDao dao = new MunicipioDao();

            return dao.InsertaMunicipio(_municipio);
        }

        public List<Municipio> obtenerMunicipio()
        {
            MunicipioDao dao = new MunicipioDao();

            return dao.obtenerEstado();
        }

        public void modificaMunicipio(Municipio _municipio)
        {
            MunicipioDao dao = new MunicipioDao();

            dao.modificaMunicipio(_municipio);
        }

        public void eliminaEstado(Municipio _municipio)
        {
            MunicipioDao dao = new MunicipioDao();

            dao.eliminaMunicipio(_municipio);
        }
    }
}
