using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de BD
/// </summary>

namespace LogicaServicio
{
    public class BD
    {
        public static DataSet EjecutarSelect(string lsql)
        {
            DataSet MiConsulta = new DataSet();
            SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["db_parcial2"].ToString());
            SqlDataAdapter MiAdaptador = new SqlDataAdapter(lsql, MiConexion);
            MiAdaptador.Fill(MiConsulta);
            return MiConsulta;
        }

        public bool EjecutarDML(string lsql)
        {
            SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["db_parcial2"].ToString());
            try
            {
                MiConexion.Open();
                SqlCommand MiComando = new SqlCommand(lsql, MiConexion);
                int filasAfectadas = MiComando.ExecuteNonQuery();
                return(filasAfectadas > 0);
            }
            catch
            {
                return false;
            }
        }

        public static object SelectEscalar(string lsql)
        {
            SqlConnection MiConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["db_parcial2"].ToString());
            SqlCommand MiComando = new SqlCommand(lsql, MiConexion);
            MiConexion.Open();
            return MiComando.ExecuteScalar();
        }
    }
}