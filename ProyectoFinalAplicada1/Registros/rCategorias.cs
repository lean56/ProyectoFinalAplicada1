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
    public partial class rCategorias : Form
    {
        public rCategorias()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
        }

        private Categorias LlenaClase()
        {
            Categorias categoria = new Categorias();

            categoria.CategoriaId = (int)IdnumericUpDown.Value;
            categoria.Nombre = DescripciontextBox.Text;

            return categoria;
        }

        private void LlenaCampo(Categorias categoria)
        {
            IdnumericUpDown.Value = categoria.CategoriaId;
            DescripciontextBox.Text = categoria.Nombre;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categoria = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (categoria != null);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categorias = new Categorias();

            int.TryParse(IdnumericUpDown.Text, out int id);

            categorias = repositorio.Buscar(id);

            if (categorias != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(categorias);
                
            }
            else
                MyErrorProvider.SetError(IdnumericUpDown, "Producto no Encontrado");
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            Categorias categoria = new Categorias();
            bool paso = false;

            //if (!Validar())
            //  return;

            categoria = LlenaClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(categoria);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Categoria que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //  if (repositorio.Duplicado(p => p.Usuario == UsuariotextBox.Text))
                //   {
                //MyErrorProvider.SetError(UsuariotextBox, "Este Usuario Ya existe!!!");
                // return;
                //  }
                paso = repositorio.Modificar(categoria);
            }
            if (paso)
            {
                MessageBox.Show("Categoria Guardada!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            MyErrorProvider.Clear();
            int.TryParse(IdnumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(IdnumericUpDown, "Categoria No Existe!!!");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Categoria Eliminada!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
