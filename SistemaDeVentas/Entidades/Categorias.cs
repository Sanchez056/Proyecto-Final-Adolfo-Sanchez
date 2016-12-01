using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
   public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }

        public string Descripcion { get; set; }

    }
}
