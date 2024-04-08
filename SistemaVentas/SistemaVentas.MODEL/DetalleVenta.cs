using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.MODEL
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TotalDetalle { get; set; }

        public Productos Producto { get; set; }


    }
}
