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
    public partial class cProductos : Form
    {
        private List<Productos> listaProductos;

        public cProductos()
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
            var listado = new List<Productos>();
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

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
                    case 1: //Todo: ID
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)))
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.ProductoId == id);
                            Imprimirbutton.Visible = true;
                        }
                        break;
                    case 2://Todo: Descripcion
                        listado = repositorio.GetList(p => p.Descripcion.Contains(CristerioTextBox.Text));
                        Imprimirbutton.Visible = true;
                        break;
                    case 3://Usuarios
                       // listado = repositorio.GetList(p => p.Categoria.Contains(CristerioTextBox.Text));
                        break;
                }


            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            if (FechacheckBox.Checked)
            {
                listado = listado.Where(c => c.FechaCreacion.Date >= DesdedateTimePicker.Value.Date && c.FechaCreacion.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            cUsuariosdataGridView.DataSource = null;
  
            cUsuariosdataGridView.DataSource = listado;

            listaProductos = listado;


            cUsuariosdataGridView.Columns[0].HeaderText = "ID";
            cUsuariosdataGridView.Columns[0].Width = 50;
            cUsuariosdataGridView.Columns[1].HeaderText = "Descripción";
            cUsuariosdataGridView.Columns[1].Width = 150;
            cUsuariosdataGridView.Columns[2].Width = 60;
            cUsuariosdataGridView.Columns[3].Width = 60;
            cUsuariosdataGridView.Columns[4].HeaderText = "% Ganancia";
            cUsuariosdataGridView.Columns[4].Width = 90;
            cUsuariosdataGridView.Columns[5].HeaderText = "Fecha Creación";
            cUsuariosdataGridView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            cUsuariosdataGridView.Columns[5].Width = 120; 
            cUsuariosdataGridView.Columns[6].Width = 100;
        }

        private void ConsultaUserbutton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count == 0)
            {
                MessageBox.Show("No Hay Datos para imprimir");
                return;
            }
            else
            {
                VentanaRptProducto rptE = new VentanaRptProducto(listaProductos);
                rptE.ShowDialog();
            }
        }
    }
}
