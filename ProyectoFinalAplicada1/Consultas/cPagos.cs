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
    public partial class cPagos : Form
    {
        private List<Pagos> listaPagos;


        public cPagos()
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
            var listado = new List<Pagos>();
            RepositorioBase<Pagos> repositorioE = new RepositorioBase<Pagos>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo: todo
                        listado = repositorioE.GetList(p => true);
                        Imprimirbutton.Visible = true;
                        break;
                    case 1: //Todo: ID
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioE.GetList(p => p.PagoId == id);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 2://Todo: IDCliente
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioE.GetList(p => p.ClienteId == id);
                            Imprimirbutton.Visible = true;
                        }        
                        break;
                    case 3://Monto
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int monto = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioE.GetList(p => p.MontoPago == monto);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                }      
            }
            else
            {
                listado = repositorioE.GetList(p => true);
            }

            if (FechacheckBox.Checked)
            {
                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            cPagosdataGridView.DataSource = null;

            cPagosdataGridView.DataSource = listado;

            listaPagos = listado;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

            if (listaPagos.Count == 0)
            {
                MessageBox.Show("No Hay Datos para imprimir");
                return;
            }
            else
            {
                VentanaRptPagos rptCl = new VentanaRptPagos(listaPagos);
                rptCl.ShowDialog();
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultaUserbutton_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
