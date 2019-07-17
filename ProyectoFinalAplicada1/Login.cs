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

        private void Accederbutton_Click(object sender, EventArgs e)
        {
            string usuario = UsuariotextBox.Text;
            string clave = ClavetextBox.Text;
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> lista = repositorio.GetList(x => true);
            foreach (var item in lista)
            {
                if (usuario == item.Usuario && clave == item.Contraseña)
                {
                    this.Visible = false;
                    new MainForm().Show();
                }
                else
                {
                    MessageBox.Show("usuario o password incorrectos ");
                }
            }
        }
    }
}
