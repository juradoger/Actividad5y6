using Empresa.DAL;
using SistemaVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class ListarVentaDal
    {
        public DataTable ListarVentas()
        {
            string consulta = "SELECT * FROM VENTAS";
            return Conexion.EjecutarDataTabla(consulta, "TABLA");
        }
        public Ventas ObtenerIdVentaDal(int id)
        {
            string consulta = "SELECT * FROM VENTAS WHERE IDVENTA = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Ventas ventas = new Ventas();
            if (tabla.Rows.Count > 0)
            {
                ventas.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                ventas.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                ventas.TotalVenta = Convert.ToDecimal(tabla.Rows[0]["totalventa"]);
            }
            return ventas;
        }
    }
}
