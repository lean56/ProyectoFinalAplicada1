using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;
using ProyectoFinalAplicada1.Consultas;
using ProyectoFinalAplicada1.Registros;

namespace ProyectoFinalAplicada1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            rUsuarios ru = new rUsuarios();
            if (repositorio.ReturnUsuario().NivelUsuario == "Administrador")
                ru.Show();
            else
                MessageBox.Show("Solo los administradores pueden registrar usuarios", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ;
        }

        private void consultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios cu = new cUsuarios();
            cu.Show();
        }

        private void registroProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos rp = new rProductos();
            rp.Show();
        }

        private void entradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaProductos entradaProductos = new rEntradaProductos();
            entradaProductos.Show();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes rc = new rClientes();
            rc.Show();
        }

        private void registroDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFacturas rf = new rFacturas();
            rf.Show();
        }

        private void loginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
         
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
