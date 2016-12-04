using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using SistemaDeVentas.Entidades;
using System.Data.Entity;
using System.Windows.Forms;

namespace SistemaDeVentas.BLL
{
   public  class VentasBLL
    {
        public static bool Insertar(Ventas factura)
        {
            bool resultado = false;
            using (var conexion = new SistemaVentasDb())
            {
                try
                {
                    conexion.Ventas.Add(factura);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
                return resultado;
            }
        }

        public static Ventas Buscar(int facturaId)
        {
            Ventas factura = null;
            using (var conexion = new SistemaVentasDb())
            {
                try
                {
                    factura = conexion.Ventas.Find(facturaId);
                    if (factura != null)
                        factura.Articulos.Count();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return factura;
        }
        public static void Eliminar(Ventas factura)
        {
            using (var conexion = new SistemaVentasDb())
            {
                try
                {

                    if (factura != null)
                    {
                        conexion.Entry(factura).State = EntityState.Deleted;

                        conexion.SaveChanges();

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }

        }




    }
}

