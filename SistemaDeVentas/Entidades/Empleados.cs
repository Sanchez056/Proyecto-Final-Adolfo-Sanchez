using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }


        public string Sexo { get; set; }

        public string FechaNacimiento { get; set; }
        public string Cedula { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public DateTime FechaIngreso { get; set; }
    }
}
