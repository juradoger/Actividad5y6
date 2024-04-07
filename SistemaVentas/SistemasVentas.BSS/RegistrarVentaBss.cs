using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.BSS;
using SistemaVentas.DAL;
using SistemaVentas.MODEL;

namespace SistemasVentas.BSS
{
    public class RegistrarVentaBss
    {
        RegistrarVentaDal dal = new RegistrarVentaDal();
        public DataTable ListarProductosBss()
        {
            //listar
            return dal.ListarProductos();
        }

        public void RegistrarVentasBss(Ventas venta, List<DetalleVenta> productos)
        {
            dal.RegistrarVenta(venta, productos);
        }
    }
}
