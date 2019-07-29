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
        List<ReciboPago> reciboFact = new List<ReciboPago>();

        public VentanaReciboFactura(List<ReciboPago> recibo)
        {
            InitializeComponent();
            this.reciboFact = recibo;
            ReciboPagos recib = new ReciboPagos();
            recib.SetDataSource(reciboFact);
            MyCrystalReportViewer.ReportSource = recib;
            MyCrystalReportViewer.Refresh();
        }
     
    }

}
