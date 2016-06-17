using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace DAL
{
    public class ParametroDao
    {
        public int InsertaParametro(Parametro _parametro)
        {
            var command = new SqlCommand("dbo.usp_AltaParametro", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cNombre", _parametro.cNombre);
            command.Parameters.AddWithValue("@cDescripcion", _parametro.cDescripcion);
            command.Parameters.AddWithValue("@cValor", _parametro.cValor);

            int folio = 0;

            try
            {
                folio = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            ConexionSingleton.cerrarConexion();
            return folio;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Parametro> obtenerParametro()
        {
            List<Parametro> list = new List<Parametro>();

            Parametro cat;

            try
            {
                var command = new SqlCommand("dbo.usp_ConsultaParametro", ConexionSingleton.abrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cat = new Parametro();
                    cat.idParametro = (int)reader["idParametro"];
                    cat.cNombre = (string)reader["cNombre"];
                    cat.cDescripcion = (string)reader["cDescripcion"];
                    cat.cValor = (string)reader["cValor"];
                    cat.FechaCreacion = (DateTime)reader["dtFechaCreacion"];
                    cat.FechaModificacion = (DateTime)reader["dtFechaModificacion"];
                    list.Add(cat);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQl Error en obtener los datos de parametro" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Code Error en obtener los datos de parametro" + ex.Message);
            }

            ConexionSingleton.cerrarConexion();

            return list;
        }
        public void modificaParametro(Parametro _parametro)
        {
            var command = new SqlCommand("SP_modificaParametro", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idParametro", _parametro.idParametro);
            command.Parameters.AddWithValue("@cNombre", _parametro.cNombre);
            command.Parameters.AddWithValue("@cDescripcion", _parametro.cDescripcion);
            command.Parameters.AddWithValue("@cValor", _parametro.cValor);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el store procedure" + ex.Message);
            }

            ConexionSingleton.cerrarConexion();
        }

        public void eliminaParametro(Parametro _parametro)
        {
            var command = new SqlCommand("SP_bajaParametro", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idParametro", _parametro.idParametro);           


            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el store procedure" + ex.Message);
            }

            ConexionSingleton.cerrarConexion();
        }
    }
}
