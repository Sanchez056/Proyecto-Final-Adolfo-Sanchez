using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Entidades
{
    public class DetalleVentas
    {
        [Key]
        public int DetelleVentaId { get; set; }
        public int VentaId { get; set; }
        public int ArticuloId { get; set; }
    }
}
