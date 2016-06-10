using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class ConexionSingleton
    {
        /// <summary>
        /// Campo que contiene la cadena de conexión de la base de datos
        /// </summary>
        const string sCadenaConexion = @"Data Source=DCM-INFORMA03\SQLEXPRESS;initial Catalog=ExpedienteElectronico;integrated Security=true";

        /// <summary>
        /// instrucción que realiza la conexión a la base de datos de acuerdo a la cadena previamente puesta
        /// </summary>
        private static readonly SqlConnection conexion = new SqlConnection(sCadenaConexion);

        /// <summary>
        /// A que se abre la conexión de la base de datos
        /// </summary>
        /// <returns></returns>
        public static SqlConnection abrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (SqlException exsql)
            {
                throw exsql;
            }

            return conexion;
        }

        /// <summary>
        /// Aca cerramos la conexión a la base de datos
        /// </summary>
        public static void cerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (SqlException exsql)
            {
                throw exsql;
            }
        }
    }
}
