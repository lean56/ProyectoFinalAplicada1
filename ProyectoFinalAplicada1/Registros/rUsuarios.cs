using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicada1.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            UsuarioradioButton.Checked = false;
            AdminradioButton.Checked = false;
            UsuariotextBox.Text = string.Empty;
            ClavemaskedTextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = (int)IdnumericUpDown.Value;
            usuario.Nombre = NombretextBox.Text;
            if (UsuarioradioButton.Checked == true)
                usuario.NivelUsuario = "Usuario";
            else
                usuario.NivelUsuario = "Administrador";
            usuario.Usuario = UsuariotextBox.Text;
            usuario.Contraseña = ClavemaskedTextBox.Text;
            usuario.FechaIngreso = FechadateTimePicker.Value;

            return usuario;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (usuario != null);
        }

        private void LlenaCampo(Usuarios usuario)
        {
            IdnumericUpDown.Value = usuario.UsuarioId;
            NombretextBox.Text = usuario.Nombre;
            if (usuario.NivelUsuario == "Usuario")
                UsuarioradioButton.Checked = true;
            else
                if (usuario.NivelUsuario == "Administrador")
                AdminradioButton.Checked = true;
            UsuariotextBox.Text = usuario.Usuario;
            ClavemaskedTextBox.Text = usuario.Contraseña;
            FechadateTimePicker.Value = usuario.FechaIngreso;
        }

        private bool Validar()
        {

            bool paso = true;


            if (NombretextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombretextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (UsuariotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuariotextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (ClavemaskedTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ClavemaskedTextBox, "Este campo no puede estar vacio");
                paso = false;
            }

            if (UsuarioradioButton.Checked == false && AdminradioButton.Checked == false)
            {
                MyErrorProvider.SetError(NivelgroupBox, "Debe elegir un tipo de usuario");
                NivelgroupBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = new Usuarios();

            int.TryParse(IdnumericUpDown.Text, out int id);

            usuario = repositorio.Buscar(id);

            if (usuario != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(usuario);
            }
            else
                MyErrorProvider.SetError(IdnumericUpDown, "Usuario no Encontrada");
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios();
            bool paso = false;

            if (!Validar())
                return;

            usuario = LlenaClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(usuario);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (repositorio.Duplicado(p => p.Usuario == UsuariotextBox.Text))
                {
                    MyErrorProvider.SetError(UsuariotextBox, "Este Usuario Ya existe!!!");
                    return;
                }
                paso = repositorio.Modificar(usuario);
            }
            if (paso)
            {
                MessageBox.Show("Usuario Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            MyErrorProvider.Clear();
            int.TryParse(IdnumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(IdnumericUpDown, "Usuario No Existe!!!");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Usuario Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
