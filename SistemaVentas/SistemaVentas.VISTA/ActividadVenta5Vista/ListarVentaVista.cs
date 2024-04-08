using SistemasVentas.BSS;
using SistemaVentas.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaVentas.VISTA.ActividadVenta5Vista
{
    public partial class ListarVentaVista : Form
    {
        int idx = 0;

        public ListarVentaVista(int _idx)
        {
            InitializeComponent();
            idx = _idx;
        }

        private void ListarDataGrid(int id)
        {


        }

        ListarDetalleVentaBss vent = new ListarDetalleVentaBss();

        private void ListarVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vent.ListarDetalleVenta(idx);
        }
    }
}
