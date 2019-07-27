﻿using Entidades;
using ProyectoFinalAplicada1.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicada1.Ventana_Reportes
{

    public partial class VentanaRptProducto : Form
    {
        List<Productos> ListaProducto = new List<Productos>();

        public VentanaRptProducto(List<Productos> producto)
        {
            InitializeComponent();
            this.ListaProducto = producto;
            ReporteProductos listadoUsuarios = new ReporteProductos();
            listadoUsuarios.SetDataSource(ListaProducto);

            MyCrystalReportViewer.ReportSource = listadoUsuarios;
            MyCrystalReportViewer.Refresh();
        }
    }
}
