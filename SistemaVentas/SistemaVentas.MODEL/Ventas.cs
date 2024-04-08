using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODEL
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TotalVenta { get; set; }
    }
}
