using BLL;
using Entidades;
using ProyectoFinalAplicada1.Reportes;
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
    public partial class cUsuarios : Form
    {
        private List<Usuarios> listaUsuario;

        public cUsuarios()
        {
            InitializeComponent();
            FiltroComboBox.SelectedItem = null;
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
            RepositorioBase<Usuarios> repositorioE = new RepositorioBase<Usuarios>();

            var listado = new List<Usuarios>();

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
                            listado = repositorioE.GetList(p => p.UsuarioId == id);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 2://Todo: Nombres
                        listado = repositorioE.GetList(p => p.Nombre.Contains(CristerioTextBox.Text));
                        Imprimirbutton.Visible = true;
                        break;
                    case 3://Usuarios
                        listado = repositorioE.GetList(p => p.Usuario.Contains(CristerioTextBox.Text));
                        break;
                }


            }
            else
            {
                listado = repositorioE.GetList(p => true);
            }

            if (FechacheckBox.Checked)
            {
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdedateTimePicker.Value.Date && c.FechaIngreso.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            cUsuariosdataGridView.DataSource = null;

            cUsuariosdataGridView.DataSource = listado;
            listaUsuario = listado;

            cUsuariosdataGridView.Columns[0].HeaderText = "ID";
            cUsuariosdataGridView.Columns[0].Width = 50;
            cUsuariosdataGridView.Columns[1].HeaderText = "Nombres";
            cUsuariosdataGridView.Columns[1].Width = 150;
            cUsuariosdataGridView.Columns[2].HeaderText = "Nivel Usuario";
            cUsuariosdataGridView.Columns[4].Visible = false;
            cUsuariosdataGridView.Columns[5].HeaderText = "Fecha Ingreso";
            cUsuariosdataGridView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void ConsultaUserbutton_Click(object sender, EventArgs e)
        {
            Buscar();
        }



        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (listaUsuario.Count == 0)
            {
                MessageBox.Show("No Hay Datos para imprimir");
                return;
            }
            else
            {
                VentanaRptUsuario rptE = new VentanaRptUsuario(listaUsuario);   
                rptE.ShowDialog();
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
