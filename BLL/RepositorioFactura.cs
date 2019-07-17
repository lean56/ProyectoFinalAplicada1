using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositorioFactura : RepositorioBase<Facturas>
    {
        public override bool Guardar(Facturas entity)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Factura.Add(entity ) != null)

                    foreach (var item in entity.Detalle)
                    {
                        contexto.Producto.Find(item.ProductoId).Inventario -= item.Cantidad;
                    }

                contexto.Cliente.Find(entity.ClienteId).Deuda += entity.Total;

                contexto.SaveChanges();
                paso = true;

                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public override bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
               Facturas factura = contexto.Factura.Find(id);

                foreach (var item in factura.Detalle)
                {
                    var EliminInventario = contexto.Producto.Find(item.ProductoId);
                    EliminInventario.Inventario += item.Cantidad;
                }

                contexto.Cliente.Find(factura.ClienteId).Deuda -= factura.Total;

                contexto.Factura.Remove(factura);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

    }
}
