﻿using Entidades;
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
    public partial class VentanaRptReciboFactura : Form
    {
        List<Facturas> ListaProducto = new List<Facturas>();

        public VentanaRptReciboFactura(List<Facturas> factura)
        {
            InitializeComponent();
            this.ListaProducto = factura;
            ReporteProductos listadoUsuarios = new ReporteProductos();
            listadoUsuarios.SetDataSource(ListaProducto);

            MyCrystalReportViewer.ReportSource = listadoUsuarios;
            MyCrystalReportViewer.Refresh();
        }
    }
}
