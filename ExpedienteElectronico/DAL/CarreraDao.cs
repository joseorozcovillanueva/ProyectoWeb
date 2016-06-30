using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEntidadesApp;
using System.Data;
using System.Data.SqlClient;

namespace WebDaoApp
{
    public class CarreraDao
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_carrera"></param>
        /// <returns></returns>
        public int InsertaCarrera(Carrera _carrera)
        {
            var command = new SqlCommand("dbo.usp_AltaCarrera", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cNombre", _carrera.Nombre);
            command.Parameters.AddWithValue("@iidInstitucion", _carrera.idInstit);

            int folio = 0;

            try
            {
                folio = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            ConexionSingleton.cerrarConexion();
            return folio;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Carrera> obtenerCarrera()
        {
            List<Carrera> list = new List<Carrera>();

            Carrera catCarrera;

            try
            {
                var command = new SqlCommand("dbo.usp_ConsultaCarrera", ConexionSingleton.abrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    catCarrera = new Carrera();
                    catCarrera.idCarrera = (int)reader["idCarrera"];
                    catCarrera.Nombre = (string)reader["Nombre"];
                    catCarrera.idInstit = (int)reader["idInstitucion"];
                    catCarrera.fechaCreacion = (DateTime)reader["FechaCreacion"];
                    catCarrera.fechaModificacion = (DateTime)reader["FechaModificacion"];
                    catCarrera.lValid = (bool)reader["lValido"];
                    catCarrera.cancelado = (bool)reader["Cancelado"];                    
                    list.Add(catCarrera);
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
        public Carrera buscaCarrera(int iCarrera, int iInstituc)
        {
            Carrera regCarrera = new Carrera();
            try
            {
                var command = new SqlCommand("dbo.usp_BuscaCarrera", ConexionSingleton.abrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@iCarrera", iCarrera);
                command.Parameters.AddWithValue("@idInst", iInstituc);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {                    
                    regCarrera.idCarrera = (int)reader["idCarrera"];
                    regCarrera.Nombre = (string)reader["Nombre"];
                    regCarrera.idInstit = (int)reader["idInstitucion"];
                    regCarrera.fechaCreacion = (DateTime)reader["FechaCreacion"];
                    regCarrera.fechaModificacion = (DateTime)reader["FechaModificacion"];
                    regCarrera.lValid = (bool)reader["lValido"];
                    regCarrera.cancelado = (bool)reader["Cancelado"];                    
                }                
            }
            catch (SqlException ex)
            {
                throw new Exception("[buscaCarrera]SQl Error en obtener los datos de modelos" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("[buscaCarrera]Code Error en obtener los datos de modelos" + ex.Message);
            }
           
            ConexionSingleton.cerrarConexion();
            return regCarrera;
        }

        public void modificaCarrera(Carrera _carrera)
        {
            var command = new SqlCommand("dbo.usp_ModificaCarrera", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idCarrera", _carrera.idCarrera);
            command.Parameters.AddWithValue("@cNombre", _carrera.Nombre);
            command.Parameters.AddWithValue("@iidInstitucion", _carrera.idInstit);
            command.Parameters.AddWithValue("@bValid", _carrera.lValid);
            command.Parameters.AddWithValue("@cCan", _carrera.cancelado);

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

        public void eliminaCarrera(Carrera _carrera)
        {
            var command = new SqlCommand("uspEliminaCarrera", ConexionSingleton.abrirConexion());

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idInstitucion", _carrera.idInstit);
            command.Parameters.AddWithValue("@idCarrera", _carrera.idCarrera);


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

