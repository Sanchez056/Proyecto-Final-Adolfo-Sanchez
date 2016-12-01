using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Entidades
{
   public  class VentaArticulos
    {
        [Key]
        public int VentaArticuloId { get; set; }

        public string  Nombre { get; set; }

        public int  Cantidad { get; set; }

        public double Precio { get; set; }

        public double Importe { get; set; }

        //public virtual List<Ventas> Ventas { get; set; }
       // Articulos v = new Articulos();
        public VentaArticulos(int articuloid, string nombre, int cantidad, double precio,double importe)
        {
            this.VentaArticuloId = articuloid; ;
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Importe =cantidad* precio;
           // Ventas= new List<Ventas>();
        }

        public VentaArticulos()
        {
            //Ventas= new List<Ventas>();
        }


    }
}
