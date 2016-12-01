using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVentas.Entidades
{
   public  class CondicionPagos
    {
        [Key]
        public int CondicionId { get; set; }

        public string Descripcion { get; set; }
    }
}
