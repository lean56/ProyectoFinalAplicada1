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
    public partial class VentanaRptPagos : Form
    {
        List<Pagos> LPagos = new List<Pagos>();

        public VentanaRptPagos(List<Pagos> pago)
        {
            InitializeComponent();
            this.LPagos = pago;
            ReportePagos recib = new ReportePagos();
            recib.SetDataSource(LPagos);
            MyCrystalReportViewer.ReportSource = recib;
            MyCrystalReportViewer.Refresh();
        }
    }
}
