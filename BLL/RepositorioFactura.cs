using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        public override bool Modificar(Facturas factura)
        {
            bool paso = false;
            Contexto db = new Contexto();

            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();

            try
            {
                var Anterior = repositorio.Buscar(factura.FacturaId);

                foreach (var item in Anterior.Detalle)
                {
                    if (!factura.Detalle.Any(d => d.FacturaDetalleId == item.FacturaDetalleId))
                    {
                        db.Producto.Find(item.ProductoId).Inventario += item.Cantidad;

                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach(var item in factura.Detalle)
                {
                    if (item.FacturaDetalleId == 0)
                    {
                        db.Producto.Find(item.ProductoId).Inventario -= item.Cantidad;

                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                        db.Entry(item).State = EntityState.Modified;
                }

                db.Entry(factura).State = EntityState.Modified;

                paso = db.SaveChanges() > 0;
               
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
