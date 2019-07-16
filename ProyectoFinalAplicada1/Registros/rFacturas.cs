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
    public partial class rFacturas : Form
    {
        public List<FacturaDetalle> detalle;


        public rFacturas()
        {
            InitializeComponent();
            detalle = new List<FacturaDetalle>();
            TotaltextBox.Text = "0.00";

        }

        private void Limpiar()
        {
            IdFacturanumericUpDown.Value = 0;
            IdClientenumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            IdProductnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CantidadtextBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
            ImportetextBox.Text = string.Empty;
            TotaltextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            TotaltextBox.Text = "0.00";
            detalle = new List<FacturaDetalle>();
            DetalledataGridView.DataSource = null;
            MyErrorProvider.Clear();
        }


        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.detalle;
        }


        private Facturas LlenaClase()
        {
            Facturas factura = new Facturas();

            factura.FacturaId = (int)IdFacturanumericUpDown.Value;
            factura.ClienteId = (int)IdClientenumericUpDown.Value;
            factura.ProductoId = (int)IdProductnumericUpDown.Value;
            factura.Total = Convert.ToDecimal(TotaltextBox.Text);
            factura.Fecha = FechadateTimePicker.Value;
            factura.Detalle = this.detalle;

            return factura;
        }

        private void LlenaCampo(Facturas factura)
        {
            IdFacturanumericUpDown.Value = factura.FacturaId;
            IdClientenumericUpDown.Value = factura.ClienteId;
            IdProductnumericUpDown.Value = factura.ProductoId;
            TotaltextBox.Text = factura.Total.ToString();
            FechadateTimePicker.Value = factura.Fecha;
            detalle = new List<FacturaDetalle>();
            this.detalle = factura.Detalle;
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            Facturas factura = repositorio.Buscar((int)IdFacturanumericUpDown.Value);
            return (factura != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();

            Facturas factura = new Facturas();
            bool paso = false;

            //if (!Validar())
            //    return;

            factura = LlenaClase();

            if (IdFacturanumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(factura);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //if (repositorio.Duplicado(p => p.Usuario == UsuariotextBox.Text))
                //{
                //    MyErrorProvider.SetError(UsuariotextBox, "Este Usuario Ya existe!!!");
                //    return;
                //}
                paso = repositorio.Modificar(factura);
            }
            if (paso)
            {
                MessageBox.Show("Usuario Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private Productos BuscarProductos(int id)
        {
            RepositorioBase<Productos> db = new RepositorioBase<Productos>();
            Productos producto = new Productos();
            try
            {
                producto = db.Buscar(id);
            }
            catch (Exception)
            {
                throw;
            }

            return producto;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            List<FacturaDetalle> detalle = new List<FacturaDetalle>();

            if (DetalledataGridView.DataSource != null)
            {
                detalle = (List<FacturaDetalle>)DetalledataGridView.DataSource;
            }
            if (DetalledataGridView.DataSource != null)
                detalle = (List<FacturaDetalle>)DetalledataGridView.DataSource;
            Productos producto = BuscarProductos((int)IdProductnumericUpDown.Value);
            if (CantidadtextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CantidadtextBox, "La Cantidad no puede ser cero");
            }
            else
            {
                MyErrorProvider.Clear();
                this.detalle.Add(
              new FacturaDetalle(
                  facturaDetalleId: 0,
                  facturaId: (int)IdFacturanumericUpDown.Value,
                  productoId: producto.ProductoId,
                  descripcion: producto.Descripcion,
                  cantidad: Convert.ToInt32(CantidadtextBox.Text),
                  precio: producto.Precio,
                  importe: Convert.ToDecimal(ImportetextBox.Text)
                  ));
            }
            CargarGrid();
            //InscripcionDetalle inscripcionD = new InscripcionDetalle();
            //TotaltextBox.Text = inscripcionD.SubTotal.ToString();

        }
        //llenar producto
        private void LlenarProducto(Productos producto)
        {
            IdProductnumericUpDown.Value = producto.ProductoId;
            DescripciontextBox.Text = producto.Descripcion;
            PreciotextBox.Text = producto.Precio.ToString();
            CantidadtextBox.Focus();
        }

        //Buscar Productos
        private void BuscarProductbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            Productos producto;

            int.TryParse(IdProductnumericUpDown.Text, out int id);

            producto = repositorio.Buscar(id);

            if (producto != null)
            {
                MyErrorProvider.Clear();
                LlenarProducto(producto);
            }
            else
                MyErrorProvider.SetError(IdProductnumericUpDown, "Producto  no encontrado!!!");
        }

        private decimal ToDecimal(object valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor.ToString(), out retorno);

            return Convert.ToDecimal(retorno);
        }

        private void CalcularImporte()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            decimal cantidad, precio;
            cantidad = ToDecimal(CantidadtextBox.Text);
            precio = ToDecimal(PreciotextBox.Text);
            ImportetextBox.Text = repositorio.CalcularImporte(cantidad, precio).ToString("0.##");
        }
        
        private void PreciotextBox_TextChanged(object sender, EventArgs e)
        {
            if (PreciotextBox.Text != string.Empty)
            {
                CalcularImporte();
            }
        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {
            if (CantidadtextBox.Text != string.Empty)
            {
                CalcularImporte();
            }
        }

        //llenar Cliente
        private void LlenarCliente(Clientes cliente)
        {
          
                NombretextBox.Text = cliente.Nombres;
            
        }
        //Buscar Cliente
        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();

            Clientes cliente;

            int.TryParse(IdClientenumericUpDown.Text, out int id);

            cliente = repositorio.Buscar(id);

            if (cliente != null)
            {
                MyErrorProvider.Clear();
                LlenarCliente(cliente);
            }
            else
                MyErrorProvider.SetError(IdClientenumericUpDown, "Cliente  no encontrado!!!");
                
        }

        private Clientes BuscarCliente(int id)
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();
            try
            {
                cliente = db.Buscar(id);
            }
            catch (Exception)
            {
                throw;
            }

            return cliente;
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BuscarFacturabutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            Facturas factura = new Facturas();
            Clientes cliente = new Clientes();

            int.TryParse(IdFacturanumericUpDown.Text, out int id);

            factura = repositorio.Buscar(id);

            if (factura != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(factura); //todo: llenar datos de la Factura
                LlenarCliente(BuscarCliente(factura.ClienteId)); //todo: llena id & nombre del Cliente
                LlenarProducto(BuscarProductos(factura.ProductoId));

            }
            else
                MyErrorProvider.SetError(IdFacturanumericUpDown, "Factura  no encontrada");
        }
    }
}
