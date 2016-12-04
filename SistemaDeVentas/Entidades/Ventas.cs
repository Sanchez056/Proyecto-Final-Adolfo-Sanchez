using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaDeVentas.Entidades
{
   public  class Ventas
    {
        [Key]
        public int VentaId { get; set; }

        public string Empleado { get; set; }

        public string Cliente { get; set; }


        public int Cantidad { get; set; }
        public double SubTotal { get; set; }

        public double Itebis { get; set; }

        public double TotalItebis { get; set; }

        public double Total { get; set; }

       

      


        public virtual List<Articulos> Articulos { get; set; }
        public Ventas(int VentaId)
        {
            this.VentaId = VentaId;
            this.Articulos = new List<Articulos>();
        }

        public Ventas()
        {
            this.Articulos = new List<Articulos>();
        }






    }
}
