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
       
            Ventas  ventas = new Ventas();

        public static bool Insertar(Ventas v)
        {
            bool re = false;
            try
            {
                var db = new SistemaVentasDb();

                db.Ventas.Add(v);
                var gp = db.Ventas.Add(v);
                foreach (var art in v.Articulos)
                {
                    db.Entry(art).State = EntityState.Unchanged;
                }
                db.SaveChanges();
                db.Dispose();
                re = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return re;
        }

    

    
        public static bool Modificar(int id, Ventas vent)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    Ventas v = db.Ventas.Find(id);
                    
                    v.Deuda = vent.Deuda;
                    v.Cantidad = vent.Cantidad;
                    v.Itebis = vent.Itebis;
                    v.Precio = vent.Precio;
                   
                    v.CodicionPago = vent.CodicionPago;
                    v.descuento = vent.descuento;
               

                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public static Ventas Buscar(int id)
            {
                var db = new SistemaVentasDb();

                return db.Ventas.Find(id);


            }



            public static bool Eliminar(int id)
            {
                //bool retorna = false;
                try
                {

                    using (var db = new SistemaVentasDb())
                    {
                    Ventas v = new Ventas();
                       v = db.Ventas.Find(id);

                        db.Ventas.Remove(v);
                        db.SaveChanges();
                        //db.Dispose();
                        return false;
                    }


                }
                catch (Exception)
                {
                    return true;
                    throw;


                }

            }




            public static List<Ventas> GetLista()
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.ToList();

                return lista;


            }

            

            public static List<Ventas> GetLista(int id)
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.Where(p => p.VentaId== id).ToList();

                return lista;

            }



          
           

           


            public static List<Ventas> GetListaFecha(DateTime aux)
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.Where(p => p.Fecha == aux).ToList();

                return lista;

            }
            public static List<Ventas> GetListaFecha(DateTime Desde, DateTime Hasta)
            {
                List<Ventas> lista = new List<Ventas>();

                var db = new SistemaVentasDb();

                lista = db.Ventas.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

                return lista;

            }

        }
    }

