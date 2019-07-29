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
            LlenarCategoria();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = "Descripción";
            DescripciontextBox.ForeColor = Color.Silver;
            CostotextBox.Text = "Costo";
            CostotextBox.ForeColor = Color.Silver;
            PreciotextBox.Text = "Precio";
            PreciotextBox.ForeColor = Color.Silver;
            GananciatextBox.Text = string.Empty;
            InventariotextBox.Text = string.Empty;
            CategoriacomboBox.SelectedItem = null;
            FechadateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }

        private Productos LlenaClase()
        {
            Productos producto = new Productos();
            
            producto.ProductoId = (int)IdnumericUpDown.Value;
            producto.Descripcion = DescripciontextBox.Text;
            producto.Categoria = Convert.ToInt32(CategoriacomboBox.SelectedValue);
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
            CategoriacomboBox.SelectedValue = producto.Categoria;
            CostotextBox.Text = producto.Costo.ToString();
            PreciotextBox.Text = producto.Precio.ToString();
            GananciatextBox.Text = producto.Ganancia.ToString();
            InventariotextBox.Text = producto.Inventario.ToString();
            FechadateTimePicker.Value = producto.FechaCreacion;
            DescripciontextBox.ForeColor = Color.Black;
            PreciotextBox.ForeColor = Color.Black;
            CostotextBox.ForeColor = Color.Black;
            GananciatextBox.ForeColor = Color.Black;
            InventariotextBox.ForeColor = Color.Black;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (producto != null);
        }


        private void LlenarCategoria()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            CategoriacomboBox.DataSource = repositorio.GetList(p => true);
            CategoriacomboBox.ValueMember = "CategoriaId";
            CategoriacomboBox.DisplayMember = "Nombre";
        }
        //buscar producto
        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = new Productos();

            int.TryParse(IdnumericUpDown.Text, out int id);

            producto = repositorio.Buscar(id);

            if (producto != null)
            {
                MyErrorProvider.Clear();
                Eliminarbutton.Enabled = true;
                LlenaCampo(producto);
                InventariotextBox.Text  = producto.Inventario.ToString();
            }
            else
                MyErrorProvider.SetError(IdnumericUpDown, "Producto no Encontrado");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripciontextBox.Text == "Descripción")
            {
                MyErrorProvider.SetError(DescripciontextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (CategoriacomboBox.SelectedValue == null)
            {
                MyErrorProvider.SetError(CategoriacomboBox, "Tiene que seleccionar una categoria");
                paso = false;
            }

            if (CostotextBox.Text == "Costo"|| CostotextBox.Text == 0.ToString())
            {
                MyErrorProvider.SetError(CostotextBox, "Este Campo Esta Vacio");
                paso = false;    
            }
            if (CostotextBox.Text!="Costo" && Convert.ToDecimal(CostotextBox.Text) > Convert.ToDecimal(PreciotextBox.Text))
            {
                MyErrorProvider.SetError(PreciotextBox, "El Precio no puede ser Menor y/o igual al precio");
                paso = false;
            }

            if (PreciotextBox.Text == "Precio"|| PreciotextBox.Text == 0.ToString())
            {
                MyErrorProvider.SetError(PreciotextBox, "Este campo no puede estar vacio");
                paso = false;        
            }
            if (PreciotextBox.Text != "Precio" && Convert.ToDecimal(CostotextBox.Text) >= Convert.ToDecimal(PreciotextBox.Text))
            {
                MyErrorProvider.SetError(PreciotextBox, "El Precio no puede ser Menor y/o igual al precio");
                paso = false;
            }

            return paso;
        }


        //guardar producto
        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            Productos producto = new Productos();
            bool paso = false;

            if (!Validar())
               return;

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
                if (repositorio.Duplicado(p => p.Descripcion == DescripciontextBox.Text))
                {
                    MyErrorProvider.SetError(DescripciontextBox, "Este Producto ya Existe!!!");
                    return;
                }
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
        //eliminar producto
        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            RepositorioBase<Usuarios> repositorioUser = new RepositorioBase<Usuarios>();

            if (repositorioUser.ReturnUsuario().NivelUsuario == "Administrador")
            {
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

            else
                MessageBox.Show("No tiene Acceso a Eliminar Producto", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);     
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
            if (costo == 0 || precio == 0)
                return;
            else
                GananciatextBox.Text = repositorio.PorcientoGanancia(costo, precio).ToString("0.##");
            

        }

        private void CostotextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (CostotextBox.Text != string.Empty)
            {
                CalcularGanancia();
            }
        }

        private void PreciotextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (PreciotextBox.Text != string.Empty)
            {
                CalcularGanancia();
            }
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            rCategorias cr = new rCategorias();
            cr.ShowDialog();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DescripciontextBox_Enter(object sender, EventArgs e)
        {
            if (DescripciontextBox.Text == "Descripción")
            {
                DescripciontextBox.Text = "";
                DescripciontextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }

        private void DescripciontextBox_Leave(object sender, EventArgs e)
        {
            if (DescripciontextBox.Text == "")
            {
                DescripciontextBox.Text = "Descripción";
                DescripciontextBox.ForeColor = Color.Silver;
            }
        }

        private void CostotextBox_Enter(object sender, EventArgs e)
        {
            if (CostotextBox.Text == "Costo")
            {
                CostotextBox.Text = "";
                CostotextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }

        private void CostotextBox_Leave(object sender, EventArgs e)
        {
            if (CostotextBox.Text == "")
            {
                CostotextBox.Text = "Costo";
                CostotextBox.ForeColor = Color.Silver;
            }
        }

        private void PreciotextBox_Enter(object sender, EventArgs e)
        {
            if (PreciotextBox.Text == "Precio")
            {
                PreciotextBox.Text = "";
                PreciotextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }

        private void PreciotextBox_Leave(object sender, EventArgs e)
        {
            if (PreciotextBox.Text == "")
            {
                PreciotextBox.Text = "Precio";
                PreciotextBox.ForeColor = Color.Silver;
            }
        }

        private void CostotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }

            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = false;
            }
        }
    }
}
