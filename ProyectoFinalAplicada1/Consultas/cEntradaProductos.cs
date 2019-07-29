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

namespace ProyectoFinalAplicada1.Consultas
{
    public partial class cEntradaProductos : Form
    {
        private List<EntradaProductos> listaEntradaProductos;

        public cEntradaProductos()
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
            var listado = new List<EntradaProductos>();
            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo: todo
                        listado = repositorio.GetList(p => true);
                        break;
                    case 1: //Todo: ID Entrada
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el IdEntrada");
                        }
                        else
                        {
                            int idEntrada = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.EntradaId == idEntrada);                        }
                        break;
                    case 2: //Todo: ID
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el IdProducto");
                        }
                        else
                        {
                            int idProducto = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.ProductoId == idProducto);
                        }
                        break;
                    case 3://Todo: Cantidad
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite la Cantidad");
                        }
                        else
                        {
                            int cantidad = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.Cantidad == cantidad);
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

            listaEntradaProductos = listado;

            cUsuariosdataGridView.Columns[0].HeaderText = "Entrada Id";
            cUsuariosdataGridView.Columns[0].Width = 90;
            cUsuariosdataGridView.Columns[1].HeaderText = "Producto Id";
            cUsuariosdataGridView.Columns[1].Width = 90;
            cUsuariosdataGridView.Columns[2].Width = 90;
            cUsuariosdataGridView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void ConsultaUserbutton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
