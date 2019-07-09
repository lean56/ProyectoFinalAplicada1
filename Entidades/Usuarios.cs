using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Usuarios
    {

        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NivelUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            NivelUsuario = string.Empty;
            Usuario = string.Empty;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
