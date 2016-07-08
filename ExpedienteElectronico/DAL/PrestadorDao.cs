using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace DAL
{
    public class PrestadorDao
    {
        public int InsertaUsuario(Prestador _Prestador)
        {
            int folio = 0;
            var command = new SqlCommand("dbo.AltaUsuario", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cNombre", _Prestador.Nombre);
            command.Parameters.AddWithValue("@cApellidoPaterno", _Prestador.ApellidoPat);
            command.Parameters.AddWithValue("@cApellidoMaterno", _Prestador.ApellidoMat);
            command.Parameters.AddWithValue("@cCelular", _Prestador.celular);
            command.Parameters.AddWithValue("@cEmail", _Prestador.eMail);
            command.Parameters.AddWithValue("@cDomicilio", _Prestador.domicilio);
            command.Parameters.AddWithValue("@cPassword", _Prestador.password);
            command.Parameters.AddWithValue("@iMatricula", _Prestador.Matricula);
            command.Parameters.AddWithValue("@nidInstitucion", 1);
            command.Parameters.AddWithValue("@nidCarrera", 1);
            command.Parameters.AddWithValue("@nidEstado", _Prestador.idEstado);
            command.Parameters.AddWithValue("@nidMunicipio", _Prestador.idMunicipio);

            try
            {
                folio = (int)command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception("SQl Error en obtener los datos de modelos" + ex.Message);
                
            }
            catch (Exception ex)
            {
                throw new Exception("Code Error AltaUsuario en obtener los datos de modelos   " + ex.Message);
                
            }

            ConexionSingleton.cerrarConexion();
            return folio;
        }
    }
}
