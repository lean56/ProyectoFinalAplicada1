using BLL;
using Entidades;
using ProyectoFinalAplicada1.Consultas;
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
            if (Menu1panel.Visible == true)
            {
                Menu1panel.Visible = false;
                Cpanel.Location = new Point(3, 84);
                CButton.Enabled = true;
            }
            else
            {
                Menu1panel.Visible = true;
                Cpanel.Location = new Point(3, 318);
                CButton.Enabled = false;

            }
        }



        private void Main_Load(object sender, EventArgs e)
        {
            Cpanel.Location = new Point(3, 84);
            Menu2panel.Visible = false;

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

        private void CButton_Click(object sender, EventArgs e)
        {
            if (Menu1panel.Visible ==false && Menu2panel.Visible == true)
            {
                Menu2panel.Visible = false;
                Rbutton.Enabled = true;
                Cpanel.Location = new Point(3, 84);
            }
            else
            {
                Menu2panel.Visible = true;
                Cpanel.Location = new Point(3, 84);
                Menu2panel.Location = new Point(3, 150);
                Rbutton.Enabled = false;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new cUsuarios());
        }
    }
}
