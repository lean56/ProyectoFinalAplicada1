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
            cUsuariosdataGridView.DataSource = null;

            listaClientes = repositorioE.GetList(p => true);

            cUsuariosdataGridView.DataSource = listado;

            cUsuariosdataGridView.Columns[0].HeaderText = "ID";
            cUsuariosdataGridView.Columns[0].Width = 50;
            cUsuariosdataGridView.Columns[1].HeaderText = "Nombres";
            cUsuariosdataGridView.Columns[1].Width = 150;
            cUsuariosdataGridView.Columns[2].HeaderText = "Nivel Usuario";
            cUsuariosdataGridView.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy";
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
               // VentanaRptUsuarios rptE = new VentanaRptUsuarios(listaUsuario);
                //rptE.ShowDialog();
            }
        }
    }
}
