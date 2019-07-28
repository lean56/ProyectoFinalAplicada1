using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ReciboPago
    {
        [Key]
        public int ReciboPagoId { get; set; }
        public string Cliente { get; set; }
        public string vendedor { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public ReciboPago()
        {
            ReciboPagoId = 0;
            Cliente = string.Empty; ;
            vendedor = string.Empty; ;
            Monto = 0;
        }
    }
}
