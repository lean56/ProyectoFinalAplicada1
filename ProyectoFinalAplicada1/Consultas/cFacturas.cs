using BLL;
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

namespace ProyectoFinalAplicada1.Consultas
{
    public partial class cFacturas : Form
    {
        private List<Facturas> listaFactura;

        public cFacturas()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(FiltroComboBox, "No ha selecionado ningun filtro");
                FiltroComboBox.Focus();
                paso = false;
            }
            if (CristerioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CristerioTextBox, "El campo Criterio esta vacio");
                CristerioTextBox.Focus();
            }
            return paso;
        }

        private void Buscar()
        {
            var listado = new List<Facturas>();
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo: todo
                        listado = repositorio.GetList(p => true);
                        Imprimirbutton.Visible = true;
                        break;
                    case 1: //Todo: Factura ID 
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el IdFactura");
                        }
                        else
                        {
                            int idfactura = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.FacturaId == idfactura);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 2: //Todo: IDCliente
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el IdCliente");
                        }
                        else
                        {
                            int idCliente = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.ClienteId == idCliente);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 3://Todo: Producto
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite la Cantidad");
                        }
                        else
                        {
                            int idProducto = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.ProductoId == idProducto);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                }
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            if (FechacheckBox.Checked)
            {
                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            cUsuariosdataGridView.DataSource = null;

            cUsuariosdataGridView.DataSource = listado;

            listaFactura = listado;

            cUsuariosdataGridView.Columns[0].HeaderText = "ID";
            cUsuariosdataGridView.Columns[0].Width = 50;
            cUsuariosdataGridView.Columns[1].HeaderText = "Cliente Id";
            cUsuariosdataGridView.Columns[1].Width = 80;
            cUsuariosdataGridView.Columns[3].HeaderText = "Producto Id";
            cUsuariosdataGridView.Columns[3].Width = 100;
            cUsuariosdataGridView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void ConsultaUserbutton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (listaFactura.Count == 0)
            {
                MessageBox.Show("No Hay Datos para imprimir");
                return;
            }
            else
            {
                VentanaRptFacturas rptE = new VentanaRptFacturas(listaFactura);
                rptE.ShowDialog();
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
