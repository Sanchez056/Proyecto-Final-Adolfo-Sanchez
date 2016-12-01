using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVentas.Entidades
{
    public class TipoUsuarios
    {
        [Key]
        public int TipoUsuarioId { get; set; }
        public string Detalle { get; set; }

    }
}
