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
    public partial class VentanaRptUsuario : Form
    {
        List<Usuarios> ListaUsuarios = new List<Usuarios>();

        public VentanaRptUsuario(List<Usuarios> usuarios)
        {
            InitializeComponent();

            this.ListaUsuarios = usuarios;
            ReporteUsuarios listadoUsuarios = new ReporteUsuarios();
            listadoUsuarios.SetDataSource(ListaUsuarios);

            MyCrystalReportViewer.ReportSource = listadoUsuarios;
            MyCrystalReportViewer.Refresh();
        }
    }
}
