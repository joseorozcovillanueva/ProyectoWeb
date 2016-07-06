using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Negocio
{
    public class PrestadorNegocio
    {
        public int CrearPrestador(Prestador _Prestador)
        {
            PrestadorDao objPrestador = new PrestadorDao();
            int idValor = 0;

            try
            {

                idValor = objPrestador.InsertaUsuario(_Prestador);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return idValor;
        }
    }
}
