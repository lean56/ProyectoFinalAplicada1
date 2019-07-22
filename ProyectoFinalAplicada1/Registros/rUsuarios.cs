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
            NombretextBox.Text = "Nombres";
            NombretextBox.ForeColor = Color.Silver;
            NivelUsercomboBox.SelectedItem = null;
            UsuariotextBox.Text = "Usuario";
            UsuariotextBox.ForeColor = Color.Silver;
            ClavemaskedTextBox.Text = "Contraseña";
            ClavemaskedTextBox.ForeColor = Color.Silver;
            ClavemaskedTextBox.UseSystemPasswordChar = false;
            Clave2maskedTextBox.Text = "Confirmar";
            Clave2maskedTextBox.ForeColor = Color.Silver;
            Clave2maskedTextBox.UseSystemPasswordChar = false;
            FechadateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = (int)IdnumericUpDown.Value;
            usuario.Nombre = NombretextBox.Text;
            usuario.NivelUsuario = NivelUsercomboBox.Text;          
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
            NivelUsercomboBox.Text = usuario.NivelUsuario;
            UsuariotextBox.Text = usuario.Usuario;
            FechadateTimePicker.Value = usuario.FechaIngreso;
            NombretextBox.ForeColor = Color.Black;
            UsuariotextBox.ForeColor = Color.Black;
            ClavemaskedTextBox.Text = "Contraseña";
            ClavemaskedTextBox.UseSystemPasswordChar = false;
            Clave2maskedTextBox.Text = "Confirmar";
            Clave2maskedTextBox.UseSystemPasswordChar = false;
        }

        private bool Validar()
        {
            bool paso = true;
     
            if (NombretextBox.Text == "Nombres")
            {
                MyErrorProvider.SetError(NombretextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (UsuariotextBox.Text == "Usuario")
            {
                MyErrorProvider.SetError(UsuariotextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (ClavemaskedTextBox.Text == "Contraseña")
            {
                MyErrorProvider.SetError(ClavemaskedTextBox, "Este campo no puede estar vacio");
                paso = false;
            }

            if (NivelUsercomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NivelUsercomboBox, "Debe elegir un tipo de usuario");
                NivelUsercomboBox.Focus();
                paso = false;
            }
            if (Clave2maskedTextBox.Text == "Confirmar")
            {
                MyErrorProvider.SetError(Clave2maskedTextBox, "Debe Confirmar la Contraseña");
                paso = false;
            }

            if (ClavemaskedTextBox.Text != Clave2maskedTextBox.Text)
            {
                MyErrorProvider.SetError(Clave2maskedTextBox, "La Contraseña no son Iguales");
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
                MyErrorProvider.SetError(IdnumericUpDown, "Usuario no Encontrado");
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

        //Todo: Eventos de textBox

        private void NombretextBox_Enter(object sender, EventArgs e)
        {
            if (NombretextBox.Text == "Nombres")
            {
                NombretextBox.Text = "";
                NombretextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }

        private void NombretextBox_Leave(object sender, EventArgs e)
        {
            if (NombretextBox.Text == "")
            {
                NombretextBox.Text = "Nombres";
                NombretextBox.ForeColor = Color.Silver;
            }
        }

        private void UsuariotextBox_Enter(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text == "Usuario")
            {
                UsuariotextBox.Text = "";
                UsuariotextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }

        private void UsuariotextBox_Leave(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text == "")
            {
                UsuariotextBox.Text = "Usuario";
                UsuariotextBox.ForeColor = Color.Silver;
            }
        }

        private void ClavemaskedTextBox_Enter(object sender, EventArgs e)
        {
            if (ClavemaskedTextBox.Text == "Contraseña")
            {
                ClavemaskedTextBox.Text = "";
                ClavemaskedTextBox.ForeColor = Color.Black;
                ClavemaskedTextBox.UseSystemPasswordChar = true;
            }
            MyErrorProvider.Clear();
        }

        private void ClavemaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (ClavemaskedTextBox.Text == "")
            {
                ClavemaskedTextBox.Text = "Contraseña";
                ClavemaskedTextBox.ForeColor = Color.Silver;
                ClavemaskedTextBox.UseSystemPasswordChar = false;

            }
        }

        private void Clave2maskedTextBox_Leave(object sender, EventArgs e)
        {
            if (Clave2maskedTextBox.Text == "")
            {
                Clave2maskedTextBox.Text = "Confirmar";
                Clave2maskedTextBox.ForeColor = Color.Silver;
                Clave2maskedTextBox.UseSystemPasswordChar = false;
            }
        }

        private void Clave2maskedTextBox_Enter(object sender, EventArgs e)
        {
            if (Clave2maskedTextBox.Text == "Confirmar")
            {
                Clave2maskedTextBox.Text = "";
                Clave2maskedTextBox.ForeColor = Color.Black;
                Clave2maskedTextBox.UseSystemPasswordChar = true;
            }
            MyErrorProvider.Clear();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    
}
