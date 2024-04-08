using Empresa.DAL;
using SistemaVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace SistemaVentas.DAL
{
    public class ListarDetalleVentaDal
    {
        ListarVentaDal dalo = new ListarVentaDal();
        public DataTable ListarDetalleVentasPorIdDal(int id)
        {
            
            string consulta = "SELECT P.IDPRODUCTO, P.NOMBRE, D.CANTIDAD, D.PRECIOUNITARIO, D.TOTALDETALLE\r\nFROM PRODUCTOS P INNER JOIN DETALLEVENTA D ON P.IDPRODUCTO = D.IDPRODUCTO INNER JOIN VENTAS V ON V.IDVENTA = D.IDVENTA\r\nWHERE V.IDVENTA = " + id;
            return Conexion.EjecutarDataTabla(consulta, "tabla");
        }
        public DetalleVenta ObtenerIdVentaDal(int id)
        {
            string consulta = "SELECT * FROM DETALLEVENTA WHERE IDDETALLEVENTA = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            DetalleVenta ventas = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                ventas.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                ventas.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                ventas.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                ventas.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["preciounitario"]);
                ventas.TotalDetalle = Convert.ToDecimal(tabla.Rows[0]["totaldetalle"]);
            }
            return ventas;
        }

    }
}
