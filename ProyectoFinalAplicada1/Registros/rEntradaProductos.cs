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
            ProductoComboBox.SelectedItem = null;
            CantidadtextBox.Text = "Cantidad";
            CantidadtextBox.ForeColor = Color.Silver;
            FechadateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
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
            CantidadtextBox.ForeColor = Color.Black;
        }

        private bool Validar()
        {
            bool paso = true;

            if (CantidadtextBox.Text == "Cantidad")
            {
                MyErrorProvider.SetError(CantidadtextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            if (ProductoComboBox.SelectedValue == null)
            {
                MyErrorProvider.SetError(ProductoComboBox, "Tiene que seleccionar un Producto");
                paso = false;
            }

            if (CantidadtextBox.Text != "Cantidad" && Convert.ToInt32(CantidadtextBox.Text) == 0)
            {
                MyErrorProvider.SetError(CantidadtextBox, "La cantidad no puede ser cero");
                paso = false;
            }

            return paso;
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
                Eliminarbutton.Enabled = true;
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
            bool paso = false;

            RepositorioEntrada db = new RepositorioEntrada();

             RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            if (!Validar())
                return;

            EntradaProductos entrada = LlenaClase();
        
            
             entrada = LlenaClase();

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

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            RepositorioEntrada db = new RepositorioEntrada();

            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();

            RepositorioBase<Usuarios> repositorioUser = new RepositorioBase<Usuarios>();

            if (repositorioUser.ReturnUsuario().NivelUsuario == "Administrador")
            {
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

            else
                MessageBox.Show("No tiene Acceso a Eliminar", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

          
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CantidadtextBox_Enter(object sender, EventArgs e)
        {
            if (CantidadtextBox.Text == "Cantidad")
            {
                CantidadtextBox.Text = "";
                CantidadtextBox.ForeColor = Color.Black;
            }
            MyErrorProvider.Clear();
        }
        private void CantidadtextBox_Leave(object sender, EventArgs e)
        {
            if (CantidadtextBox.Text == "")
            {
                CantidadtextBox.Text = "Cantidad";
                CantidadtextBox.ForeColor = Color.Silver;
            }
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
