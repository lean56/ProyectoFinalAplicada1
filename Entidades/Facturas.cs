using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }


        //public virtual List<FacturaDetalle> Detalle { get; set; }



    }
}