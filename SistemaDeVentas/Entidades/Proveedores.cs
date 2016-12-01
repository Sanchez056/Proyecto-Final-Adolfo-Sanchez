using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entidades
{
   public  class Proveedores
    {
         [Key]
        public int ProveedorId{ get; set; }

        public string  NombreProveedor{ get; set; }


        public string Ciudad { get; set; }

        public string Direccion { get; set; }

        


        public string Telefono{ get; set; }

        public string Fax{ get; set; }

        public string Correo { get; set; }

       public DateTime FechaIngreso { get; set; }


    }
}
