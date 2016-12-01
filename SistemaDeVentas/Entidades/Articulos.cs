using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entidades;
using System.ComponentModel;

namespace SistemaDeVentas.Entidades
{
    public class Articulos
    {
        [Key]

        public int ArticuloId { get; set; }
   
        public string Nombre { get; set; }

        [Browsable(false)]
        public string Descripcion { get; set; }
        [Browsable(false)]
        public string Marca { get; set; }

        [Browsable(false)]
        public string NombreProveedor { get; set; }

       [Browsable(false)]
        public string Categoria { get; set; }
       [Browsable(false)]
        public int CantidadDispodible { get; set; }

        public int Cantidad { get; set; }

        [Browsable(false)]
        public double Descuento { get; set; }

         [Browsable(false)]
        public double PrecioCompra { get; set; }

        public double Precio { get; set; }

        public double  Importe { get; set; }



        [Browsable(false)]
        public DateTime Fecha { get; set; }

        //------------------------
        public virtual List<Ventas> Ventas { get; set; }

      
        public Articulos()
        {
            this.Ventas = new List<Ventas>();
           
        }

   
        public Articulos(int articuloId,string nombre,int cantidad,double precio,double importe)
        {
            this.ArticuloId = articuloId;
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Importe = Cantidad*Precio;
            this.Ventas = new List<Ventas>();
           
        }
       


    }
}

