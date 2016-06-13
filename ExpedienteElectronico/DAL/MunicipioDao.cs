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
    public class MunicipioDao
    {
        public int InsertaMunicipio(Municipio _municipio)
        {
            var command = new SqlCommand("dbo.usp_CreaMunicipio", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idEstado", _municipio.idEstado);
            command.Parameters.AddWithValue("@cNombre", _municipio.Nombre);

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
        public List<Municipio> obtenerEstado()
        {
            List<Municipio> list = new List<Municipio>();

            Municipio cat;

            try
            {
                var command = new SqlCommand("dbo.usp_ConsultaMunicipio", ConexionSingleton.abrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cat = new Municipio();
                    cat.idMunicipio = (int)reader["idMunicipio"];
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
        public void modificaMunicipio(Municipio _municipio)
        {
            var command = new SqlCommand("SP_modificaMunicipio", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idMunicipio", _municipio.idMunicipio);
            command.Parameters.AddWithValue("@idEstado", _municipio.idEstado);
            command.Parameters.AddWithValue("@cNombre", _municipio.Nombre);

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

        public void eliminaMunicipio(Municipio _municipio)
        {
            var command = new SqlCommand("SP_EliminaMunicipio", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idMunicipio", _municipio.idMunicipio);
            command.Parameters.AddWithValue("@idEstado", _municipio.idEstado);


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
