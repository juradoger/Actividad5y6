using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemaVentas.MODEL;

namespace SistemaVentas.VISTA.Actividad5Vista
{
    public partial class RegistrarVentaVista : Form
    {
        RegistrarVentaBss bss = new RegistrarVentaBss();

        List<Productos> productos = new List<Productos>();

        BindingList<DetalleVenta> detalleVenta = new BindingList<DetalleVenta>();
        public RegistrarVentaVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var venta = new Ventas()
            {
                Fecha = dateTimePicker1.Value,
                TotalVenta = Convert.ToDecimal(label4.Text)
            };

            bss.RegistrarVentasBss(venta, detalleVenta.ToList());

            MessageBox.Show("Venta registrada con exito");

            Reset();
        }

        public void Reset()
        {
            detalleVenta.Clear();

            label4.Text = "0";
            ListarDataGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ListarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = detalleVenta;

            dataGridView1.Columns["IdProducto"].Visible = false;
            dataGridView1.Columns["IdVenta"].Visible = false;
            dataGridView1.Columns["IdDetalleVenta"].Visible = false;
            dataGridView1.Columns["TotalDetalle"].Visible = false;

            dataGridView1.Columns["Producto"].DisplayIndex = 0;
        }

        private void RegistrarVentaVista_Load(object sender, EventArgs e)
        {
            DataTable productosDB = bss.ListarProductosBss();

            ListarDataGrid();

            foreach (DataRow row in productosDB.Rows)
            {
                productos.Add(new Productos
                {
                    IdProducto = Convert.ToInt32(row["IdProducto"]),
                    Nombre = row["Nombre"].ToString(),
                    PrecioUnitario = Convert.ToDecimal(row["PrecioUnitario"])
                });

                comboBox1.Items.Add($"{row["Nombre"]} - {row["PrecioUnitario"]}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            if (index >= 0)
            {
                Productos producto = productos[index];

                detalleVenta.Add(new DetalleVenta()
                {
                    Cantidad = 1,
                    PrecioUnitario = producto.PrecioUnitario,
                    IdProducto = producto.IdProducto,
                    Producto = producto,
                });

                decimal totalVenta = Convert.ToDecimal(label4.Text) + producto.PrecioUnitario;
                label4.Text = totalVenta.ToString();

                ListarDataGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("hola");

            decimal total = 0;

            foreach (var item in detalleVenta)
            {
                total += item.Cantidad * item.PrecioUnitario;
            }

            label4.Text = total.ToString();
        }
    }
}
