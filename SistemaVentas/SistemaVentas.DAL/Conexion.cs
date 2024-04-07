using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Empresa.DAL
{
    public class Conexion
    {

        public static string CONECTAR
        {
            get { return @"Data Source=DESKTOP-76VU9AG; Initial Catalog=SISTEMA_G_VENTAS; Integrated Security=True; TrustServerCertificate=true;"; }
        }
        public static DataSet EjecutarDataSet(string consulta)
        {
            string p = Conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "TABLA");
            return ds;
        }

        public static void Ejecutar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            cmd.ExecuteNonQuery();
        }


        public static int EjecutarEscalar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();

            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            Convert.ToInt32(cmd.ExecuteScalar());

            SqlCommand cmd2 = new SqlCommand("SELECT SCOPE_IDENTITY()", conectar);
            int id = Convert.ToInt32(cmd2.ExecuteScalar());

            return id;
        }

        public static DataTable EjecutarDataTabla(string consulta, string tabla)
        {
            string p = Conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(tabla);
            da.Fill(dt);
            return dt;
        }

    }
}
