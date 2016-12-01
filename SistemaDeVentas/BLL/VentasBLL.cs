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

        public static bool Insertar(Ventas venta)
        {
            bool retorna = false;
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    db.Ventas.Add(venta);
                    db.SaveChanges();
                    retorna = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
                return retorna;
            }
        }

        public static Ventas Buscar(int ventaId)
        {
            Ventas venta = null;
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    venta = db.Ventas.Find(ventaId);
                    if (venta != null)
                        venta.Articulos.Count();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return venta;
        }
        public static void Eliminar(Ventas venta)
        {
            using (var db = new SistemaVentasDb())
            {
                try
                {

                    if (venta != null)
                    {
                        db.Entry(venta).State = EntityState.Deleted;

                        db.SaveChanges();

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }

        }






        //public static List<Ventas> GetListaFecha(DateTime aux)
        //    {
        //        List<Ventas> lista = new List<Ventas>();

        //        var db = new SistemaVentasDb();

        //        lista = db.Ventas.Where(p => p.Fecha == aux).ToList();

        //        return lista;

        //    }
        //    public static List<Ventas> GetListaFecha(DateTime Desde, DateTime Hasta)
        //    {
        //        List<Ventas> lista = new List<Ventas>();

        //        var db = new SistemaVentasDb();

        //        lista = db.Ventas.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

        //        return lista;

        //    }

        }
    }

