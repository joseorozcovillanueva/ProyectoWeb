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
    public class EstadoDao
    {
        public int InsertaEstado(Estado _estado)
        {
            var command = new SqlCommand("dbo.usp_CreaEstado", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cNombre", _estado.Nombre);
            
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
        public List<Estado> obtenerEstado()
        {
            List<Estado> list = new List<Estado>();

            Estado cat;

            try
            {
                var command = new SqlCommand("dbo.usp_ConsultaEstado", ConexionSingleton.abrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cat = new Estado();
                    cat.idEstado = (int)reader["idEstado"];
                    cat.Nombre = (string)reader["Nombre"];
                    cat.FechaCreacion = (DateTime)reader["FechaCreacion"];
                    cat.FechaModificacion = (DateTime)reader["FechaModificacion"];
                    list.Add(cat);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQl Error en obtener los datos de modelos" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Code Error en obtener los datos de modelos" + ex.Message);
            }

            ConexionSingleton.cerrarConexion();

            return list;
        }
        public void modificaEstado(Estado _estado)
        {
            var command = new SqlCommand("SP_modificaEstado", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idEstado", _estado.idEstado);
            command.Parameters.AddWithValue("@cNombre", _estado.Nombre);            

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

        public void eliminaEstado(Estado _estado)
        {
            var command = new SqlCommand("SP_EliminaEstado", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idEstado", _estado.idEstado);


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
