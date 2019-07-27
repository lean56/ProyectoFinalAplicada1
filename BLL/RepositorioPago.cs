using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class RepositorioPago : RepositorioBase<Pagos>
    {
        public override bool Guardar(Pagos entity)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Pago.Add(entity) != null)
                {
                    contexto.Cliente.Find(entity.ClienteId).Deuda -= entity.MontoPago;

                    contexto.SaveChanges();
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

        /*
        public override bool Modificar(Pagos entity)
        {
            bool paso = false;

            Contexto contexto = new Contexto();

            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();

            try
            {
                EntradaProductos EntradaAnterior = repositorio.Buscar(entrada.EntradaId);

                int diferencia;
                diferencia = entrada.Cantidad - EntradaAnterior.Cantidad;

                var Producto = contexto.Producto.Find(EntradaAnterior.ProductoId);

                Producto.Inventario += diferencia;

                contexto.Entry(entrada).State = EntityState.Modified;

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
        */

        public override bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Pagos pago = contexto.Pago.Find(id);

                contexto.Cliente.Find(pago.ClienteId).Deuda += pago.MontoPago;

                contexto.Pago.Remove(pago);

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
