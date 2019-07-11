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
            NombretextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            CelularmaskedTextBox.Clear();
            EmailtextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
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
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (cliente != null);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();

            int.TryParse(IdnumericUpDown.Text, out int id);

            cliente = repositorio.Buscar(id);

            if (cliente != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(cliente);
            }
            else
                MyErrorProvider.SetError(IdnumericUpDown, "Cliente no Encontrado");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

            Clientes cliente = new Clientes();
            bool paso = false;

            //if (!Validar())
            //    return;

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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
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
    }
}
