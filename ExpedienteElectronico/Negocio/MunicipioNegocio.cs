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

        public List<Municipio> obtenerMunicipio(int _id)
        {
            MunicipioDao dao = new MunicipioDao();

            return dao.obtenerMunicipio(_id);
        }

        public void modificaMunicipio(Municipio _municipio)
        {
            MunicipioDao dao = new MunicipioDao();

            dao.modificaMunicipio(_municipio);
        }

        public void eliminaMunicipio(Municipio _municipio)
        {
            MunicipioDao dao = new MunicipioDao();

            dao.eliminaMunicipio(_municipio);
        }
    }
}
