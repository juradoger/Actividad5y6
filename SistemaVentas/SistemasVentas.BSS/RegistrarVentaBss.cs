using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.BSS;
using SistemaVentas.DAL;

namespace SistemasVentas.BSS
{
    public class RegistrarVentaBss
    {
        RegistrarVentaDal dal = new RegistrarVentaDal();
        public DataTable ListarProductosBss()
        {
            return dal.ListarProductos();
        }
    }
}
