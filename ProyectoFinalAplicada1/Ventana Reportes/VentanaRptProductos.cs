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
    public partial class VentanaRptProductos : Form
    {
        List<Productos> ListadoUsuarios = new List<Productos>();

        public VentanaRptProductos(List<Productos> producto)
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteProductos datos = new ReporteProductos();
            datos.SetDataSource(ListadoUsuarios);
            ProductoscrystalReportViewer.ReportSource = datos;
            ProductoscrystalReportViewer.Refresh();
        }
    }
}
