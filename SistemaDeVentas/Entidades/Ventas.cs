using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeVentas.Entidades
{
   public  class Ventas
    {
        [Key]
        public int VentaId { get; set; }

      
        public string CodicionPago { get; set; }

        public string Cliente { get; set; }

        public string  Empleado { get; set; }

        public int descuento  { get; set; }



         public double Deuda { get; set; }

      //  public DateTime FechaVencimiento { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }

        public double Itebis  { get; set; }

        public double SubTotal { get; set; }

        public double TotalDescuento { get; set; }
        public  double TotalItebis   { get; set; }

        public double Total { get; set; }



        public DateTime Fecha { get; set; }

        public virtual List<Articulos> Articulos { get; set; }

        public Ventas()
        {
            this.Articulos = new List<Articulos>();
        }


        // [Browsable(false)]
        public Ventas(int ventaId, string codigo,string codicionPago,double subTotal,double totalDesuento,double totalItebis,double total,DateTime fecha)
        {

            this.VentaId = ventaId;
            this.CodicionPago =codicionPago;
            this.SubTotal = subTotal;
            this.TotalDescuento = totalDesuento;
            this.TotalItebis = totalItebis;
            this.Total = total;
            this.Articulos = new List<Articulos>();
        }








    }
}
