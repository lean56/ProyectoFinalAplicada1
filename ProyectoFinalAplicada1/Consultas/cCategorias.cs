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
    public partial class cCategorias : Form
    {
        private List<Categorias> listaCategorias;

        public cCategorias()
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
            var listado = new List<Categorias>();
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo: todo
                        listado = repositorio.GetList(p => true);
                        break;
                    case 1: //Todo: ID
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.CategoriaId == id);
                        }
                        break;
                    case 2://Todo: Descripcion
                        listado = repositorio.GetList(p => p.Nombre.Contains(CristerioTextBox.Text));
                        break;
                }


            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            //if (FechacheckBox.Checked)
            //{
            //    listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            //}
            cUsuariosdataGridView.DataSource = null;

            cUsuariosdataGridView.DataSource = listado;

            listaCategorias = listado;

            cUsuariosdataGridView.Columns[0].HeaderText = "Categoría Id";
            cUsuariosdataGridView.Columns[0].Width = 90;
            cUsuariosdataGridView.Columns[1].HeaderText = "Descripción";
            cUsuariosdataGridView.Columns[1].Width = 150;
            
        }

        private void ConsultaUserbutton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (listaCategorias.Count == 0)
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

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
