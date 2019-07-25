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
    public partial class VentanaRptClientes : Form
    {
        List<Clientes> ListadoClientes = new List<Clientes>();


        public VentanaRptClientes(List<Clientes>clientes)
        {
            InitializeComponent();
            ListadoClientes = clientes;
        }

        private void ClientescrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReporteClientes datos = new ReporteClientes();
            datos.SetDataSource(ListadoClientes);
            ClientescrystalReportViewer.ReportSource = datos;
            ClientescrystalReportViewer.Refresh();
        }

    }
}
