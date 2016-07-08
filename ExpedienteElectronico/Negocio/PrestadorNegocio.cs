using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.SqlClient;

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
            catch (SqlException ex)
            {
                throw new Exception("SQl Error en obtener los datos de institución" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Code Error en obtener los datos de institución" + ex.Message);
            }

            return idValor;
        }
    }
}
