using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class FacturaDetalle
    {
        [Key]
        public int FacturaDetalleId { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public FacturaDetalle()
        {
            FacturaDetalleId = 0;
            FacturaId = 0;
            ProductoId = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }

        public FacturaDetalle(int facturaDetalleId, int facturaId, int productoId, string descripcion, int cantidad, decimal precio, decimal importe)
        {
            FacturaDetalleId = facturaDetalleId;
            FacturaId = facturaId;
            ProductoId = productoId;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }

       
    }
}
