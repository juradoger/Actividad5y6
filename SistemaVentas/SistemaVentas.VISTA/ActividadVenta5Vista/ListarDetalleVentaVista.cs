using Empresa.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.ActividadVenta5Vista
{
    public partial class ListarDetalleVentaVista : Form
    {
        public ListarDetalleVentaVista()
        {
            InitializeComponent();
        }

        
        ListarDetalleVentaBss bssd = new ListarDetalleVentaBss();
        RegistrarVentaBss b = new RegistrarVentaBss();
        private void ListarDetalleVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentas();
        }
        public static int IdVenta = 0;
        ListarVentaBss bss = new ListarVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            ListarVentaVista fr = new ListarVentaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                int idx = bss.ObtenerIdVentasBss(IdVenta);
            }
        }
    }
}
