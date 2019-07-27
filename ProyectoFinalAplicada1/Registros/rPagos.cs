using BLL;
using DAL;
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
    public partial class rPagos : Form
    {
        public rPagos()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>(new Contexto());

            ClienteComboBox.DataSource = repositorio.GetList(c => true);
            ClienteComboBox.ValueMember = "ClienteId";
            ClienteComboBox.DisplayMember = "Nombre";
        }

        private Pagos LlenaClase()
        {
            Pagos pago = new Pagos();

            pago.PagoId = (int)IdNumericUpDown.Value;
            pago.ClienteId = Convert.ToInt32(ClienteComboBox.SelectedValue);
            pago.MontoPago = Convert.ToInt32(MontotextBox.Text);
            pago.Fecha = FechadateTimePicker.Value;

            return pago;
        }

        private void LlenaCampo(Pagos pago)
        {
            IdNumericUpDown.Value = pago.PagoId;
            ClienteComboBox.SelectedValue = pago.ClienteId;
            MontotextBox.Text = pago.MontoPago.ToString();
            FechadateTimePicker.Value = pago.Fecha;
            MontotextBox.ForeColor = Color.Black;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Pagos> repositorio = new RepositorioBase<Pagos>();
            Pagos pago = repositorio.Buscar((int)IdNumericUpDown.Value);
            return (pago != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Pagos> repositorio = new RepositorioBase<Pagos>();
            Pagos pago = new Pagos();

            int.TryParse(IdNumericUpDown.Text, out int id);

            pago = repositorio.Buscar(id);

            if (pago != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(pago);
            }
            else
                MyErrorProvider.SetError(IdNumericUpDown, "Pago no Encontrado");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            //Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;

            RepositorioPago db = new RepositorioPago();

            RepositorioBase<Pagos> repositorio = new RepositorioBase<Pagos>();
            // if (!Validar())
            //return;

            Pagos pago = LlenaClase();


            pago = LlenaClase();

            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(pago);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Pago que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //  if (repositorio.Duplicado(p => p.Usuario == UsuariotextBox.Text))
                //   {
                //MyErrorProvider.SetError(UsuariotextBox, "Este Usuario Ya existe!!!");
                // return;
                //  }
                paso = db.Modificar(pago);
            }
            if (paso)
            {
                MessageBox.Show("Pago Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
