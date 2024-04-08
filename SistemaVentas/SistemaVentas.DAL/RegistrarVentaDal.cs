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
    public class RegistrarVentaDal
    {
        public DataTable ListarProductos()
        {
            string consulta = "SELECT * FROM PRODUCTOS";
            return Conexion.EjecutarDataTabla(consulta, "tabla");
        }
        public void RegistrarVenta(Ventas ventas, List<DetalleVenta> productos)
        {
            string consulta = $"INSERT INTO VENTAS VALUES ('{ventas.Fecha.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {ventas.TotalVenta.ToString().Replace(',', '.')})";
            int idVenta = Conexion.EjecutarEscalar(consulta);

            foreach (DetalleVenta producto in productos)
            {
                consulta = $"INSERT INTO DETALLEVENTA VALUES ({idVenta}, {producto.IdProducto}, {producto.Cantidad}, {producto.PrecioUnitario.ToString().Replace(',', '.')}, {(producto.Cantidad * producto.PrecioUnitario).ToString().Replace(',', '.')})";
                Conexion.Ejecutar(consulta);
            }
        }
        public Productos ObtenerIdProducto(int id)
        {
            string consulta = "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO = "+id;
            DataTable fila = Conexion.EjecutarDataTabla(consulta, "tabla");
            Productos productos = new Productos();
            if (fila.Rows.Count > 0)
            {
                productos.IdProducto = Convert.ToInt32(fila.Rows[0]["idproducto"]);
                productos.Nombre = fila.Rows[0]["nombre"].ToString();
                productos.PrecioUnitario = Convert.ToDecimal(fila.Rows[0]["preciounitario"]);
            }
            return productos;
        }

    }
}
