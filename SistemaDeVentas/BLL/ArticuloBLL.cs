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
using SistemaDeVentas.BLL;

namespace BLL
{
    public class ArticuloBLL
    {
        Articulos articulos= new Articulos();
        public static bool Insertar(Articulos articulo)
        {
            bool retorna = false;
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    if (Buscar(articulo.ArticuloId) == null)
                    {
                        db.Articulos.Add(articulo);
                    }
                    else
                        db.Entry(articulo).State = EntityState.Modified;
                    db.SaveChanges();

                    retorna = true;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                return retorna;
            }

        }
        public static void Eliminar(Articulos articulo)
        {
            using (var db = new SistemaVentasDb())
            {
                try
                {

                    if (articulo != null)
                    {
                        db.Entry(articulo).State = EntityState.Deleted;

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
        public static Articulos Buscar(int id)
        {
            var articulo = new Articulos();
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    articulo = db.Articulos.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return articulo;
        }
        public static List<Articulos> GetLista()
        {
            List<Articulos> lista = new List<Articulos>();

            using (var db = new SistemaVentasDb())
            {
                try
                {
                    lista = db.Articulos.ToList();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
                return lista;
            }
        }

        public static List<Articulos> GetLista(int id)
        {
            List<Articulos> lista = new List<Articulos>();

            using (var db = new SistemaVentasDb())
            {
                try
                {
                    lista = db.Articulos.Where(p => p.ArticuloId == id).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return lista;
        }
        public static double GetPrecio(int id)
        {
            double precio = 0;
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    Articulos a = db.Articulos.Where(art => art.ArticuloId == id).FirstOrDefault();
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
        public static List<Articulos> ListaCombo()
        {
            List<Articulos> lista = null;
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    lista = db.Articulos.Where(p => p.Cantidad <= 0 && p.Importe <= 0).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static List<Articulos> Articulo(int ventaid)
        {
            var articulo = new List<Articulos>();
            using (var db = new SistemaVentasDb())
            {
                try
                {
                    var venta = VentasBLL.Buscar(ventaid);
                    if (venta != null)
                        articulo= venta.Articulos;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return articulo;
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
