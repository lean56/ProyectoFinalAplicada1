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
    public partial class rEntradaProductos : Form
    {
        public rEntradaProductos()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            ProductoComboBox.SelectedIndex = 0;
            CantidadtextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
        }

        private EntradaProductos LlenaClase()
        {
            EntradaProductos entrada = new EntradaProductos();

            entrada.EntradaId = (int)IdNumericUpDown.Value;
            entrada.ProductoId = Convert.ToInt32(ProductoComboBox.SelectedValue);
            entrada.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            entrada.Fecha = FechadateTimePicker.Value;

            return entrada;
        }

        private void LlenaCampo(EntradaProductos entrada)
        {
            IdNumericUpDown.Value = entrada.EntradaId;
            ProductoComboBox.SelectedValue = entrada.ProductoId;
            CantidadtextBox.Text = entrada.Cantidad.ToString() ;
            FechadateTimePicker.Value = entrada.Fecha;
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>(new Contexto());

            ProductoComboBox.DataSource = repositorio.GetList(c => true);
            ProductoComboBox.ValueMember = "ProductoId";
            ProductoComboBox.DisplayMember = "Descripcion";
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            EntradaProductos entrada = repositorio.Buscar((int)IdNumericUpDown.Value);
            return (entrada != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            EntradaProductos entrada = new EntradaProductos();

            int.TryParse(IdNumericUpDown.Text, out int id);

            entrada = repositorio.Buscar(id);

            if (entrada != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(entrada);
            }
            else
                MyErrorProvider.SetError(IdNumericUpDown, "Entrada de Producto no Encontrado");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            EntradaBLL db = new EntradaBLL();

            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();

            EntradaProductos entrada = LlenaClase();
            bool paso = false;

            //if (!Validar())
            //  return;

          //  entrada = LlenaClase();

            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(entrada);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Entrada de Producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //  if (repositorio.Duplicado(p => p.Usuario == UsuariotextBox.Text))
                //   {
                //MyErrorProvider.SetError(UsuariotextBox, "Este Usuario Ya existe!!!");
                // return;
                //  }
                paso = db.Modificar(entrada);
            }
            if (paso)
            {
                MessageBox.Show("Entrada de Producto Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            EntradaBLL db = new EntradaBLL();

            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            MyErrorProvider.Clear();
            int.TryParse(IdNumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(IdNumericUpDown, "Entrada de Producto No Existe!!!");
                return;
            }
            if (db.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Entrada de Producto Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
