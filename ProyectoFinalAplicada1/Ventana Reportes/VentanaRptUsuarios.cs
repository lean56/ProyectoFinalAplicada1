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
    public partial class VentanaRptUsuarios : Form
    {
        List<Usuarios> ListadoUsuarios = new List<Usuarios>();

        public VentanaRptUsuarios(List<Usuarios>usuario)
        {
            InitializeComponent();
            ListadoUsuarios = usuario;
        }

        private void UsuarioscrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReporteUsuarios datos = new ReporteUsuarios();
            datos.SetDataSource(ListadoUsuarios);
            UsuarioscrystalReportViewer.ReportSource = datos;
            UsuarioscrystalReportViewer.Refresh();
        }
    }
}
