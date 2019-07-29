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
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Text = "Nombres";
            NombretextBox.ForeColor = Color.Silver;
            DirecciontextBox.Text = "Dirección";
            DirecciontextBox.ForeColor = Color.Silver;
            EmailtextBox.Text = "Email";
            EmailtextBox.ForeColor = Color.Silver;
            CedulamaskedTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            CelularmaskedTextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }

        private Clientes LlenaClase()
        {
            Clientes cliente = new Clientes()
            {
                ClienteId = (int)IdnumericUpDown.Value,
                Nombres = NombretextBox.Text,
                Direccion = DirecciontextBox.Text,
                Email = EmailtextBox.Text,
                Cedula = CedulamaskedTextBox.Text,
                Telefono = TelefonomaskedTextBox.Text,
                Celular = CelularmaskedTextBox.Text,
                Fecha = FechadateTimePicker.Value
            };
            return cliente;
        }

        private void LlenaCampo(Clientes cliente)
        {
            IdnumericUpDown.Value = cliente.ClienteId;
            NombretextBox.Text = cliente.Nombres;
            DirecciontextBox.Text = cliente.Direccion;
            EmailtextBox.Text = cliente.Email;
            CedulamaskedTextBox.Text = cliente.Cedula;
            TelefonomaskedTextBox.Text = cliente.Telefono;
            CelularmaskedTextBox.Text = cliente.Cedula;
            FechadateTimePicker.Value = cliente.Fecha;

            NombretextBox.ForeColor = Color.Black;
            DirecciontextBox.ForeColor = Color.Black;
            EmailtextBox.ForeColor = Color.Black;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (cliente != null);
        }


        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();

            int.TryParse(IdnumericUpDown.Text, out int id);

            cliente = repositorio.Buscar(id);

            if (cliente != null)
            {
                MyErrorProvider.Clear();
                Eliminarbutton.Enabled = true;
                LlenaCampo(cliente);
            }
            else
                MyErrorProvider.SetError(IdnumericUpDown, "Cliente no Encontrado");
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            bool paso = true;

            if (NombretextBox.Text == "Nombres")
            {
                MyErrorProvider.SetError(NombretextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (DirecciontextBox.Text == "Dirección")
            {
                MyErrorProvider.SetError(DirecciontextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (EmailtextBox.Text == "Email")
            {
                MyErrorProvider.SetError(EmailtextBox, "Este campo no puede estar vacio");
                paso = false;
            }

            if (CedulamaskedTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CedulamaskedTextBox, "Este campo no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }
            if (TelefonomaskedTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(TelefonomaskedTextBox, "Este campo no puede estar vacio");
                paso = false;
            }

            if (CelularmaskedTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CelularmaskedTextBox, "Este campo no puede estar vacio");
                paso = false;
            }

            return paso;
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

            Clientes cliente = new Clientes();
            bool paso = false;

            if (!Validar())
                return;

            cliente = LlenaClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(cliente);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Cliente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //if (repositorio.Duplicado(p => p.Usuario == UsuariotextBox.Text))
                //{
                //    MyErrorProvider.SetError(UsuariotextBox, "Este Usuario Ya existe!!!");
                //    return;
                //}
                paso = repositorio.Modificar(cliente);
            }
            if (paso)
            {
                MessageBox.Show("Cliente Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();


            RepositorioBase<Usuarios> repositorioUser = new RepositorioBase<Usuarios>();

            if (repositorioUser.ReturnUsuario().NivelUsuario == "Administrador")
            {
                MyErrorProvider.Clear();
                int.TryParse(IdnumericUpDown.Text, out int id);

                if (!ExisteEnLaBaseDeDatos())
                {
                    MyErrorProvider.SetError(IdnumericUpDown, "Cliente No Existe!!!");
                    return;
                }
                if (repositorio.Eliminar(id))
                {
                    Limpiar();
                    MessageBox.Show("Cliente Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("No tiene Acceso a Eliminar Cliente", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }

        //Todo: Eventos de TextBox
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

        private void DirecciontextBox_Enter(object sender, EventArgs e)
        {
            if (DirecciontextBox.Text == "Dirección")
            {
                DirecciontextBox.Text = "";
                DirecciontextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }

        private void DirecciontextBox_Leave(object sender, EventArgs e)
        {
            if (DirecciontextBox.Text == "")
            {
                DirecciontextBox.Text = "Dirección";
                DirecciontextBox.ForeColor = Color.Silver;
            }
        }

        private void EmailtextBox_Enter(object sender, EventArgs e)
        {
            if (EmailtextBox.Text == "Email")
            {
                EmailtextBox.Text = "";
                EmailtextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }

        private void EmailtextBox_Leave(object sender, EventArgs e)
        {
            if (EmailtextBox.Text == "")
            {
                EmailtextBox.Text = "Email";
                EmailtextBox.ForeColor = Color.Silver;
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
