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

namespace ProyectoFinalAplicada1.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CostotextBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
            GananciatextBox.Text = string.Empty;
            InventariotextBox.Text = string.Empty;
           // CategoriacomboBox.SelectedIndex = 0;
            FechadateTimePicker.Value = DateTime.Now;
        }

        private Productos LlenaClase()
        {
            Productos producto = new Productos();
            
            producto.ProductoId = (int)IdnumericUpDown.Value;
            producto.Descripcion = DescripciontextBox.Text;
            producto.Costo = Convert.ToDecimal(CostotextBox.Text);
            producto.Precio = Convert.ToDecimal(PreciotextBox.Text);
            producto.Ganancia = Convert.ToDecimal(GananciatextBox.Text);
            producto.Inventario = 0;
            producto.FechaCreacion = FechadateTimePicker.Value;
           
            return producto;
        }

        private void LlenaCampo(Productos producto)
        {
            IdnumericUpDown.Value = producto.ProductoId;
            DescripciontextBox.Text = producto.Descripcion;
            CostotextBox.Text = producto.Costo.ToString();
            PreciotextBox.Text = producto.Precio.ToString();
            GananciatextBox.Text = producto.Ganancia.ToString();
            InventariotextBox.Text = producto.Inventario.ToString();
            FechadateTimePicker.Value = producto.FechaCreacion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (producto != null);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = new Productos();

            int.TryParse(IdnumericUpDown.Text, out int id);

            producto = repositorio.Buscar(id);

            if (producto != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(producto);
                InventariotextBox.Text = producto.Inventario.ToString();
            }
            else
                MyErrorProvider.SetError(IdnumericUpDown, "Producto no Encontrado");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            Productos producto = new Productos();
            bool paso = false;

            //if (!Validar())
              //  return;

            producto = LlenaClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(producto);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              //  if (repositorio.Duplicado(p => p.Usuario == UsuariotextBox.Text))
             //   {
                    //MyErrorProvider.SetError(UsuariotextBox, "Este Usuario Ya existe!!!");
                   // return;
              //  }
                paso = repositorio.Modificar(producto);
            }
            if (paso)
            {
                MessageBox.Show("Producto Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            MyErrorProvider.Clear();
            int.TryParse(IdnumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(IdnumericUpDown, "Producto No Existe!!!");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Producto Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private decimal ToDecimal(object valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor.ToString(), out retorno);

            return Convert.ToDecimal(retorno);
        }

        private void CalcularGanancia()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            decimal costo, precio;
            costo = ToDecimal(CostotextBox.Text);
            precio = ToDecimal(PreciotextBox.Text);
            GananciatextBox.Text = repositorio.PorcientoGanancia(costo, precio).ToString("0.##");
        }

        private void CostotextBox_TextChanged(object sender, EventArgs e)
        {
            if (CostotextBox.Text != string.Empty)
            {
                CalcularGanancia();
            }
        }

        private void PreciotextBox_TextChanged(object sender, EventArgs e)
        {
            if (PreciotextBox.Text != string.Empty)
            {
                CalcularGanancia();
            }
        }
    }
}
