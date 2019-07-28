using BLL;
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
    public partial class VentanaReciboFactura : Form
    {
        List<Entidades.ReciboPago> reciboFact = new List<Entidades.ReciboPago>();

        public VentanaReciboFactura(List<Entidades.ReciboPago> recibo)
        {
            this.reciboFact = recibo;

            InitializeComponent();
            Cargar();
        }

        private void Cargar()
        {
            ReciboPagos recib = new ReciboPagos();
            recib.SetDataSource(reciboFact);
            MyCrystalReportViewer.ReportSource = recib;
            MyCrystalReportViewer.Refresh();
        }

        private void MyCrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReciboFactura datos = new ReciboFactura();
            datos.SetDataSource(reciboFact);
            MyCrystalReportViewer.ReportSource = datos;
            MyCrystalReportViewer.Refresh();
        }
        
    }

}
