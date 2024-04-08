using SistemaVentas.DAL;
using SistemaVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ListarDetalleVentaBss
    {

        ListarDetalleVentaDal dal = new ListarDetalleVentaDal();
        public DetalleVenta ObtnerIdDVenta(int id)
        {
            return dal.ObtenerIdVentaDal(id);
        } 
        public DataTable ListarDetalleVenta(int id)
        {
            return dal.ListarDetalleVentasPorIdDal(id);
        }
    }
}
