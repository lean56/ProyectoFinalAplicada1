using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            rUsuarios ru = new rUsuarios();
            ru.Show();
        }

        private void consultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios cu = new cUsuarios();
            cu.Show();
        }
    }
}
