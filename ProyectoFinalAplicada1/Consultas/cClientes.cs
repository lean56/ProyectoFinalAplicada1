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
    public partial class cClientes : Form
    {
        private List<Clientes> listaClientes;

        public cClientes()
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
            var listado = new List<Clientes>();
            RepositorioBase<Clientes> repositorioE = new RepositorioBase<Clientes>();

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
                            listado = repositorioE.GetList(p => p.ClienteId == id);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 2://Todo: Nombres
                        listado = repositorioE.GetList(p => p.Nombres.Contains(CristerioTextBox.Text));
                        Imprimirbutton.Visible = true;
                        break;
                    case 3://Usuarios
                        listado = repositorioE.GetList(p => p.Direccion.Contains(CristerioTextBox.Text));
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
            cClientesdataGridView.DataSource = null;

            cClientesdataGridView.DataSource = listado;

            listaClientes = listado;

            cClientesdataGridView.Columns[0].HeaderText = "ID";
            cClientesdataGridView.Columns[0].Width = 50;
            cClientesdataGridView.Columns[1].HeaderText = "Nombres";
            cClientesdataGridView.Columns[1].Width = 150;
            cClientesdataGridView.Columns[2].HeaderText = "Cédula";
            cClientesdataGridView.Columns[3].HeaderText = "Dirección";
            cClientesdataGridView.Columns[4].HeaderText = "Telefono";
            cClientesdataGridView.Columns[5].HeaderText = "Celular";
            cClientesdataGridView.Columns[6].HeaderText = "Email";
            cClientesdataGridView.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            cClientesdataGridView.Columns[8].HeaderText = "Deuda";

        }

        private void ConsultaUserbutton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (listaClientes.Count == 0)
            {
                MessageBox.Show("No Hay Datos para imprimir");
                return;
            }
            else
            {
                 VentanaRptClientes rptCl = new VentanaRptClientes(listaClientes);
                 rptCl.ShowDialog();
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
