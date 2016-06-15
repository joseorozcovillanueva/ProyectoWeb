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
    public class InstitucionDao
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_institucion"></param>
        /// <returns></returns>
        public int InsertaInstitucion(Institucion _institucion)
        {
            // alta de usuario

            var command = new SqlCommand("dbo.usp_AltaInst", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cNombreInstitucion", _institucion.NombreInstitucion);
            command.Parameters.AddWithValue("@cDireccion", _institucion.Direccion);


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
        public List<Institucion> obtenerInstitucion()
        {
            List<Institucion> list = new List<Institucion>();

            Institucion cat;

            try
            {
                var command = new SqlCommand("dbo.usp_ConsultaInst", ConexionSingleton.abrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cat = new Institucion();
                    cat.idInstitucion = (int)reader["IdInstitucion"];
                    cat.NombreInstitucion = (string)reader["nombreInstitucion"];
                    cat.Direccion = (string)reader["Direccion"];
                    cat.fechaCreacion = (DateTime)reader["FechaCreacion"];
                    list.Add(cat);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQl Error en obtener los datos de institución" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Code Error en obtener los datos de institución" + ex.Message);
            }

            ConexionSingleton.cerrarConexion();

            return list;
        }
        public void modificaInstitucion(Institucion _institucion)
        {
            var command = new SqlCommand("SP_modificaInstitucion", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idInstitucion", _institucion.idInstitucion);
            command.Parameters.AddWithValue("@cNombreInstitucion", _institucion.NombreInstitucion);
            command.Parameters.AddWithValue("@cDireccion", _institucion.Direccion);
            command.Parameters.AddWithValue("@lValido", _institucion.lValido);

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

        public void eliminaInstitucion(Institucion _institucion)
        {
            var command = new SqlCommand("SP_EliminaInstitucion", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idInstitucion", _institucion.idInstitucion);


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
