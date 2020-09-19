using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Registro.Entidades
{
   public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public DateTime Fecha  { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }


    }
}
