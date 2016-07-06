using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Negocio
{
    public class CarreraNegocio
    {
        public int insertarCarrera(Carrera _carrera)
        {
            CarreraDao dao = new CarreraDao();

            return dao.InsertaCarrera(_carrera);
        }

        public List<Carrera> obtenerCarrera()
        {
            CarreraDao dao = new CarreraDao();

            return dao.obtenerCarrera();
        }

        public void modificaCarrera(Carrera _carrera)
        {
            CarreraDao dao = new CarreraDao();

            dao.modificaCarrera(_carrera);
        }

        public void eliminaCarrera(Carrera _carrera)
        {
            CarreraDao dao = new CarreraDao();

            dao.eliminaCarrera(_carrera);
        }

        public Carrera buscaCarrera(int _idCarrera, int idInstituto)
        {
            
            CarreraDao dao = new CarreraDao();

            return dao.buscaCarrera(_idCarrera, idInstituto);
        }
    }
}
