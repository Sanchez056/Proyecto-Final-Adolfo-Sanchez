using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace SistemaDeVentas.BLL
{
    public class CategoriaBLL
    {
       
            Categorias categoria = new Categorias();

            public static bool Insertar(Categorias c)
            {
                //  bool retorna = false;

                try
                {

                    using (var db = new SistemaVentasDb())
                    {

                        db.Categorias.Add(c);
                        db.SaveChanges();
                        db.Dispose();
                        // retorna= true;
                        return true;

                    }


                }
                catch (Exception)
                {
                    return false;
                    throw;

                }

                // return retorna;

            }
        public static bool Modificar(int id, Categorias cat)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    Categorias c = db.Categorias.Find(id);
                    c.Descripcion = cat.Descripcion;                
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

        public static Categorias Buscar(int id)
            {
                var db = new SistemaVentasDb();

                return db.Categorias.Find(id);


            }



            public static bool Eliminar(int id)
            {
                //bool retorna = false;
                try
                {

                    using (var db = new SistemaVentasDb())
                    {
                        Categorias c = new Categorias();
                        c = db.Categorias.Find(id);

                        db.Categorias.Remove(c);
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




            public static List<Categorias> GetLista()
            {
                List<Categorias> lista = new List<Categorias>();

                var db = new SistemaVentasDb();

                lista = db.Categorias.ToList();

                return lista;


            }



            public static List<Categorias> GetLista(int id)
            {
                List<Categorias> lista = new List<Categorias>();

                var db = new SistemaVentasDb();

                lista = db.Categorias.Where(p => p.CategoriaId == id).ToList();

                return lista;

            }



            public static List<Categorias> GetListaDescripcion(string aux)
            {
                List<Categorias> lista = new List<Categorias>();

                var db = new SistemaVentasDb();

                lista = db.Categorias.Where(p => p.Descripcion == aux).ToList();

                return lista;

            }
        }
    }

