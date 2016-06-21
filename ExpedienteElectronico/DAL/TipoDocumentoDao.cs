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
    public class TipoDocumentoDao
    {
        public int InsertaTipoDocumento(TipoDocumento _tipoDocumento)
        {
            var command = new SqlCommand("dbo.usp_AltaTipoDoc", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cNombre", _tipoDocumento.Nombre);
            command.Parameters.AddWithValue("@cRutaImagen", _tipoDocumento.cRutaImagen);
            

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
        public List<TipoDocumento> obtenerTipoDocumento()
        {
            List<TipoDocumento> list = new List<TipoDocumento>();

            TipoDocumento cat;

            try
            {
                var command = new SqlCommand("dbo.usp_ConTipoDoc", ConexionSingleton.abrirConexion());
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cat = new TipoDocumento();
                    cat.idTipoDocumento = (int)reader["idTipoDocumento"];
                    cat.Nombre = (string)reader["Nombre"];
                    cat.cRutaImagen = (string)reader["cRutaImagen"];
                    cat.dtFechaCreacion = (DateTime)reader["dtFechaCreacion"];
                    cat.dtFechaModificacion = (DateTime)reader["dtFechaModificacion"];
                    list.Add(cat);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQl Error en obtener los datos de Tipo de Documento" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Code Error en obtener los datos de Tipo de Documento" + ex.Message);
            }

            ConexionSingleton.cerrarConexion();

            return list;
        }
        public void modificaTipoDocumento(TipoDocumento _tipoDocumento)
        {
            var command = new SqlCommand("SP_ModTipoDoc", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idTipoDocumento", _tipoDocumento.idTipoDocumento);
            command.Parameters.AddWithValue("@cNombre", _tipoDocumento.Nombre);
            command.Parameters.AddWithValue("@cDescripcion", _tipoDocumento.cRutaImagen);            

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

        public void eliminaTipoDocumento(TipoDocumento _tipoDocumento)
        {
            var command = new SqlCommand("SP_BajaTipoDoc", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idTipoDocumento", _tipoDocumento.idTipoDocumento);


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
