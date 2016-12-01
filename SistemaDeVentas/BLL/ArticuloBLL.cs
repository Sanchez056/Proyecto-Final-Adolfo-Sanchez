using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Entidades;
using SistemaDeVentas.Entidades;
using System.Windows.Forms;
using System.Data.Entity;

namespace BLL
{
    public class ArticuloBLL
    {
        Articulos articulos= new Articulos();

        public static bool Insertar(Articulos a)
        {
            bool re = false;
            try
            {
                SistemaVentasDb db = new SistemaVentasDb();

                db.Articulos.Add(a);
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
    
        public static bool  Modificar(int id, Articulos art)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    Articulos a = db.Articulos.Find(id);
                    a.Nombre = art.Nombre;
                    a.Marca = art.Marca;
                    a.NombreProveedor = art.NombreProveedor;
                    a.PrecioCompra= art.PrecioCompra;
                    a.Precio = art.Precio;
                    a.CantidadDispodible = art.CantidadDispodible;
                    a.Categoria = art.Categoria;

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

        public static Articulos Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Articulos.Find(id);

        }
        public static Articulos BuscarNombre(string nombre)
        {
            var db = new SistemaVentasDb();

            return db.Articulos.Find(nombre);

        }
        public static Articulos BuscarCodigo(int id)
        {
            var db = new SistemaVentasDb();

            return db.Articulos.Find(id);

        }

        




        public static bool Eliminar(int id)
        {
            //bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    Articulos a = new Articulos();
                    a = db.Articulos.Find(id);

                    db.Articulos.Remove(a);
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

    


        public static List<Articulos> GetLista()
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.ToList();

            return lista;


        }

       

        public static List<Articulos> GetLista(int articuloId)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.ArticuloId == articuloId).ToList();

            return lista;

        }



        public static List<Articulos> GetListaNombreArticulo(string aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Nombre== aux).ToList();

            return lista;

        }
        public static List<Articulos> GetListaMarcaArticulo(string aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Marca== aux).ToList();

            return lista;

        }
        public static double GetListaPrecio(int id)
        {
            double precio = 0;
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    Articulos a = db.Articulos.Where(aO => aO.ArticuloId== id).FirstOrDefault();
                    precio = a.Precio;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
                return precio;
            }

        }

      

        
      
       public static List<Articulos> GetListaFecha(DateTime aux)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Fecha== aux).ToList();

            return lista;

        }
       public static List<Articulos> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Articulos> lista = new List<Articulos>();

            var db = new SistemaVentasDb();

            lista = db.Articulos.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

            return lista;

        }
        
    }
}
