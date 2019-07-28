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
    public partial class VentaraImprimirFactura : Form
    {
        List<FacturaDetalle> lista;
        public VentaraImprimirFactura(List< FacturaDetalle> factura)
        {
            InitializeComponent();
            this.lista = factura;
            Factura facturas = new Factura();
            facturas.SetDataSource(lista);
            MyCrystalReportViewer.ReportSource = facturas;
            MyCrystalReportViewer.Refresh();
            //Cargar();
        }

        private void Cargar()
        {
           // prueba facturas = new prueba();
           // facturas.SetDataSource(lista);
          // MyCrystalReportViewer.ReportSource = facturas;
            //MyCrystalReportViewer.Refresh();
        }
    }
}
