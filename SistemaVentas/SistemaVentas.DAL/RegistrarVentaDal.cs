﻿using Empresa.DAL;
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
        public void RegistrarVenta(Ventas ventas)
        {
            string consulta = $"INSERT INTO VENTA VALUES ('{ventas.Fecha.ToString("yyyy-mm-dd HH:mm:ss")}', {ventas.TotalVenta})";
            Conexion.Ejecutar(consulta);
        }
        public Productos ObtenerPrecioProducto(int id)
        {
            string consulta = "SELECT * FROM PRODUCTOS";
            DataTable fila = Conexion.EjecutarDataTabla(consulta, "tabla");
            Productos productos = new Productos();
            if(fila.Rows.Count > 0)
            {

            }
        }
    }
}
