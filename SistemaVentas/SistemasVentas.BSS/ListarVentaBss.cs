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
    public class ListarVentaBss
    {
        ListarVentaDal dal = new ListarVentaDal();
        public DataTable ListarVentas()
        {
            return dal.ListarVentas();
        }
        public Ventas ObtenerIdVentasBss(int id)
        {
            return dal.ObtenerIdVentaDal(id);
        }
    }
}
