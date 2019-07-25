using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ProyectoFinalAplicada1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        void Loading()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(8);
            }
        }


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (UsuariotextBox.Text == "Usuario")
            {
                MyErrorProvider.SetError(UsuariotextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }
     
            if (ClavetextBox.Text == "Contraseña")
            {
                MyErrorProvider.SetError(ClavetextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }
     
            return paso;
        }


        private void Logins()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            List<Usuarios> usuario = new List<Usuarios>();

            Expression<Func<Usuarios, bool>> filtrar = x => true;

            filtrar = t => t.Usuario.Equals(UsuariotextBox.Text);
            usuario = repositorio.GetList(filtrar);


            if (usuario.Exists(x => x.Usuario == UsuariotextBox.Text) && usuario.Exists(x => x.Contraseña == ClavetextBox.Text))
            {
                foreach (var item in repositorio.GetList(x => x.Usuario == UsuariotextBox.Text))
                {
                    repositorio.NombreLogin(item.Usuario, item.NivelUsuario);
                }

                using (loading lo = new loading(Loading))
                {
                    this.Hide();
                    lo.ShowDialog(this);

                    new Main().Show();
                }
            }
            else
            {
                MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpiar(); 
            }
        }

        private void Limpiar()
        {
            UsuariotextBox.Text = "Usuario";
            UsuariotextBox.ForeColor = Color.Silver;
            ClavetextBox.Text = "Contraseña";
            ClavetextBox.ForeColor = Color.Silver;
            ClavetextBox.UseSystemPasswordChar = false;
            MyErrorProvider.Clear();
        }

        private void accederbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            Logins();
        }

        private void UsuariotextBox_Leave(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text == "")
            {
                UsuariotextBox.Text = "Usuario";
                UsuariotextBox.ForeColor = Color.Silver;
            }
        }


        private void UsuariotextBox_Enter(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text == "Usuario")
            {
                UsuariotextBox.Text = "";
                UsuariotextBox.ForeColor = Color.LightGray;
            }
            MyErrorProvider.Clear();
        }

        private void ClavetextBox_Leave(object sender, EventArgs e)
        {
            if (ClavetextBox.Text == "")
            {
                ClavetextBox.Text = "Contraseña";
                ClavetextBox.ForeColor = Color.Silver;
                ClavetextBox.UseSystemPasswordChar = false;
            }
        }

        private void ClavetextBox_Enter(object sender, EventArgs e)
        {
            if (ClavetextBox.Text == "Contraseña")
            {
                ClavetextBox.Text = "";
                ClavetextBox.ForeColor = Color.LightGray;
                ClavetextBox.UseSystemPasswordChar = true;
            }
            MyErrorProvider.Clear();
        }

        private void ClavetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logins();        
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Logins_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
