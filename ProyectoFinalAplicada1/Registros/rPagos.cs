using BLL;
using DAL;
using Entidades;
using ProyectoFinalAplicada1.Ventana_Reportes;
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

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            ClienteComboBox.SelectedItem = null;
            MontotextBox.Text = "Monto";
            MontotextBox.ForeColor = Color.Silver;
            FechadateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

            ClienteComboBox.DataSource = repositorio.GetList(c => true);
            ClienteComboBox.ValueMember = "ClienteId";
            ClienteComboBox.DisplayMember = "Nombres";
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
            Limpiar();
        }

        private bool Validar()
        {
            bool paso = true;

            if (MontotextBox.Text == "Monto")
            {
                MyErrorProvider.SetError(MontotextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (ClienteComboBox.SelectedValue == null)
            {
                MyErrorProvider.SetError(ClienteComboBox, "Tiene que seleccionar un Cliente");
                paso = false;
            }

            if (MontotextBox.Text != "Monto" && Convert.ToInt32(MontotextBox.Text) == 0)
            {
                MyErrorProvider.SetError(MontotextBox, "El Monto no puede ser cero");
                paso = false;
            }

            return paso;
        }


        public bool ValidarMonto(Pagos pago)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            int MontoActual = Convert.ToInt32(MontotextBox.Text);
            int MontoAnterior = Convert.ToInt32(contexto.Cliente.Find(pago.ClienteId).Deuda);

            if (MontoActual > MontoAnterior)
            {
                MessageBox.Show($"La deuda del cliente es de {MontoAnterior}");
                MyErrorProvider.SetError(MontotextBox, "Cantidad Mayor a la deuda");
                paso = true; 
            }
            else
            if (MontoAnterior > MontoActual)
            {
                MessageBox.Show($"La deuda del cliente es de {MontoAnterior}");
                MyErrorProvider.SetError(MontotextBox, "Cantidad Menor a la deuda");
                paso = true;
            }

            return paso;
        }
        private void Recibo()
        {
            RepositorioBase<ReciboPago> Repositorio = new RepositorioBase<ReciboPago>(); // Creando el recibo de ingreso

            ReciboPago Recibo = new ReciboPago();
            Recibo.Cliente = ClienteComboBox.Text;
            Recibo.Monto = Convert.ToInt32(MontotextBox.Text);
            Recibo.Fecha = FechadateTimePicker.Value;

            Repositorio.Guardar(Recibo);

            if (MessageBox.Show("Desea generar el recibo de pago?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) // Haciendo el recibo de pago
            {      
               List<ReciboPago> ReciboDeIngreso = new List<ReciboPago>();

                ReciboDeIngreso.Insert(0, Recibo);
                VentanaReciboFactura reciboDePagoReportViewer = new VentanaReciboFactura(ReciboDeIngreso);
                reciboDePagoReportViewer.ShowDialog();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;

            RepositorioPago db = new RepositorioPago();

            RepositorioBase<Pagos> repositorio = new RepositorioBase<Pagos>();
             if (!Validar())
            return;

            Pagos pago = LlenaClase();

            if (ValidarMonto(pago))
            {
                return;
            }
            else

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
                paso = db.Modificar(pago);
            }
            if (paso)
            {
                MessageBox.Show("Pago Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioPago db = new RepositorioPago();

            RepositorioBase<Pagos> repositorio = new RepositorioBase<Pagos>();
            MyErrorProvider.Clear();
            int.TryParse(IdNumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(IdNumericUpDown, "Pago No Existe!!!");
                return;
            }
            if (db.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Pago Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MontotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void MontotextBox_Enter(object sender, EventArgs e)
        {
            if (MontotextBox.Text == "Monto")
            {
                MontotextBox.Text = "";
                MontotextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }

        private void MontotextBox_Leave(object sender, EventArgs e)
        {
            if (MontotextBox.Text == "")
            {
                MontotextBox.Text = "Monto";
                MontotextBox.ForeColor = Color.Silver;
            }
        }
    }
}
