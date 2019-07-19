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

namespace ProyectoFinalAplicada1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        void Loading()
        {
            for(int i=0; i<=500;i++)
            {
                Thread.Sleep(8);
            }
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

                using (loading main = new loading(Loading))
                {
                    this.Hide();
                    main.ShowDialog(this);

                    new MainForm().Show();
                }

            } //string usuario = UsuariotextBox.Text;
              //string contraseña = ClavetextBox.Text;
              // List<Usuarios> lista = repositorio.GetList(x => true);
              //foreach (var item in lista)
              //{
              //    if (usuario.(x => x.NombreUsuario == UsuariologtextBox.Text) && usuario.Exists(x => x.Clave == ClavetextBox.Text))

            //        // if (usuario == item.Usuario && contraseña == item.Contraseña)
            //        {
            //        repositorio.NombreLogin(item.Usuario, item.NivelUsuario);
            //        this.Hide();
            //        new MainForm().Show();
            //   }

            //if (Lista != null)
            //{
            //    foreach (var item in repositorio.GetList(x => x.Usuario == UsuariotextBox.Text))
            //    {
            //        repositorio.NombreLogin(item.Usuario, item.NivelUsuario);
            //    }
            //    this.Hide();
            //    Thread hilo = new Thread(InterfazUsuario);
            //    hilo.Start();

            //    return;
            //}
            else
            {
                MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClavetextBox.Clear();
            }
        }

        private void Accederbutton_Click(object sender, EventArgs e)
        {
            Logins();
        }

 
        private void ClavetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logins();
            }
        }
    }
}
