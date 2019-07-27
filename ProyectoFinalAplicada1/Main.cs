using BLL;
using Entidades;
using ProyectoFinalAplicada1.Consultas;
using ProyectoFinalAplicada1.Properties;
using ProyectoFinalAplicada1.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicada1
{
    public partial class Main : Form
    {
        private bool isCollapsed1;
        private bool isCollapsed2;
        private bool isCollapsed3;



        public Main()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void Rbutton_Click_2(object sender, EventArgs e)
        {
            Registrotimer.Start();
        }

        private void RUsuarioButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            if (repositorio.ReturnUsuario().NivelUsuario == "Administrador")
                AbrirFormInPanel(new rUsuarios());
            else
                MessageBox.Show("No tiene Acceso a registrar Usuarios", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Max_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Max.Visible = false;
            restaurar.Visible = true;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            Max.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 180)
            {
                MenuVertical.Width = 60;
            }
            else
                MenuVertical.Width = 180;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarSeccionbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Salir?", "Cerrar Seccion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            if (result == DialogResult.No)
            {
                Main p = new Main();
                p.Show();
            }
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Userlabel.Text = repositorio.ReturnUsuario().Usuario;
        }
        private bool isCollapsed;

        private void CButton_Click(object sender, EventArgs e)
        {
            Consultatimer.Start();
        }

        private void BarraTitulo_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Max.Visible = false;
            restaurar.Visible = true;
        }

        private void RegistroProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rProductos());
        }

        private void EntradadeProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rEntradaProductos());
        }

        private void ClienteAdd_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rClientes());
        }

        private void FacturaButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rFacturas());
        }

        private void ClienteAdd_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new rClientes());
        }

        private void Menu2panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                cProductoButton.Image = Resources.Collapse_Arrow_20px;
                ConsultaPanel.Height += 10;
                if (ConsultaPanel.Size == ConsultaPanel.MaximumSize)
                {
                    FacturaPanel.Location = new Point(3, 320);
                    Reportepanel.Location = new Point(3, 350);
                    CReporte.Enabled = false;
                    Rbutton.Enabled = false;
                    CFactura.Enabled = false;
                    Consultatimer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                cProductoButton.Image = Resources.Expand_Arrow_20px;
                ConsultaPanel.Height -= 10;
                if (ConsultaPanel.Size == ConsultaPanel.MinimumSize)
                {
                    FacturaPanel.Location = new Point(3, 160);
                    Reportepanel.Location = new Point(3, 220);

                    CReporte.Enabled = true;
                    Rbutton.Enabled = true;
                    CFactura.Enabled = true;
                    Consultatimer.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Registrotimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                Rbutton.Image = Resources.Collapse_Arrow_20px;
                RegistroPanel.Height += 10;
                if (RegistroPanel.Size == RegistroPanel.MaximumSize)
                {
                    ConsultaPanel.Location = new Point(3, 225);
                    FacturaPanel.Location = new Point(3, 260);
                    Reportepanel.Location = new Point(3, 300);
                    CReporte.Enabled = false;
                    CFactura.Enabled = false;
                    Registrotimer.Stop();
                    isCollapsed1 = false;
                    CButton.Enabled = false;

                }
            }
            else
            {
                Rbutton.Image = Resources.Expand_Arrow_20px;
                RegistroPanel.Height -= 10;
                if (RegistroPanel.Size == RegistroPanel.MinimumSize)
                {
                    CFactura.Enabled = true;
                    CReporte.Enabled = true;
                    ConsultaPanel.Location = new Point(3, 125);
                    FacturaPanel.Location = new Point(3, 155);
                    Reportepanel.Location = new Point(3, 190);
                    CButton.Enabled = true;
                    Registrotimer.Stop();
                    isCollapsed1 = true;
                }
            }
        }

        private void CFactura_Click(object sender, EventArgs e)
        {
            FacturaTimer.Start();
        }

        private void FacturaTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                CFactura.Image = Resources.Collapse_Arrow_20px;
                FacturaPanel.Height += 10;
                if (FacturaPanel.Size == FacturaPanel.MaximumSize)
                {
                    Reportepanel.Location = new Point(3, 250);
                    FacturaTimer.Stop();
                    isCollapsed2 = false;
                    CButton.Enabled = false;
                    Rbutton.Enabled = false;
                    CReporte.Enabled = false;

                }
            }
            else
            {
                CFactura.Image = Resources.Expand_Arrow_20px;
                FacturaPanel.Height -= 10;
                if (FacturaPanel.Size == FacturaPanel.MinimumSize)
                {
                    Reportepanel.Location = new Point(3, 190);       
                    Rbutton.Enabled = true;
                    CButton.Enabled = true;
                    CReporte.Enabled = true;
                    FacturaTimer.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void Reportetimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                CReporte.Image = Resources.Collapse_Arrow_20px;
                Reportepanel.Height += 10;
                if (Reportepanel.Size == Reportepanel.MaximumSize)
                {
                    Reportetimer.Stop();
                    isCollapsed3 = false;
                    CFactura.Enabled = false;
                    CButton.Enabled = false;
                    Rbutton.Enabled = false;

                }
            }
            else
            {
                CReporte.Image = Resources.Expand_Arrow_20px;
                Reportepanel.Height -= 10;
                if (Reportepanel.Size == Reportepanel.MinimumSize)
                {
                    CFactura.Enabled = true;
                    Rbutton.Enabled = true;
                    CButton.Enabled = true;
                    Reportetimer.Stop();
                    isCollapsed3 = true;
                }
            }
        }

        private void CReporte_Click(object sender, EventArgs e)
        {
            Reportetimer.Start();
        }
        //Todo: Consultas
        private void cClienteButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cClientes());
        }

        private void cProductoButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cProductos());
        }

        private void cEntradaButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cEntradaProductos());
        }

        private void cCategoriaButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cCategorias());
        }

        private void cFacturaButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cFacturas());
        }

        private void cUsuarioButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cUsuarios());
        }

        private void rptUsuarioButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cUsuarios());
        }

        private void rptProductosButton_Click(object sender, EventArgs e)
        {

        }

        private void rptEntradaButton_Click(object sender, EventArgs e)
        {

        }

        private void rptCategoriaButton_Click(object sender, EventArgs e)
        {

        }

        private void RptFacturasButton_Click(object sender, EventArgs e)
        {

        }
    }
}
