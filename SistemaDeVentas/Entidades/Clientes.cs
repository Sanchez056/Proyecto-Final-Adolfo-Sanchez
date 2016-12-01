using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        public string Nombre { get; set; }


        public string Sexo { get; set; }

        public string Cedula { get; set; }


        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public DateTime Fecha { get; set; }

       // public int Cuotas { get; set; }

       /// public double Deuda { get; set; }

       // public DateTime   FechaVencimientoFactura {get; set; }

        


    }
}
