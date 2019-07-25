using Entidades;
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
    public partial class VentanaRptFacturas : Form
    {
        List<Facturas> ListadoFacturas = new List<Facturas>();

        public VentanaRptFacturas(List<Facturas> facturas)
        {
            InitializeComponent();
            ListadoFacturas = facturas;

        }

        private void FacturascrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReporteFacturas datos = new ReporteFacturas();
            datos.SetDataSource(ListadoFacturas);
            FacturascrystalReportViewer.ReportSource = datos;
            FacturascrystalReportViewer.Refresh();
        }
    }
}
