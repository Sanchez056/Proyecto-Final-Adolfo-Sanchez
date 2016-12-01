using DAL;
using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.BLL
{
   public  class CondicionPagosBLL
    {

        CondicionPagos usuario = new CondicionPagos();

        public static bool Insertar(CondicionPagos c)
        {
            bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.CodicionPagos.Add(c);
                    db.SaveChanges();
                    //db.Dispose();
                    retorna = true;
                }


            }
            catch (Exception)
            {
                throw;

            }
            return retorna;

        }
        public static bool Modificar(int id, CondicionPagos cps)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    CondicionPagos cp = db.CodicionPagos.Find(id);
                    cp.Descripcion = cps.Descripcion; 
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


        public static CondicionPagos Buscar(int id)
        {
            var db = new SistemaVentasDb();
            return db.CodicionPagos.Find(id);
        }

        public static bool Eliminar(int id)
        {
            
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    CondicionPagos cps = new CondicionPagos();
                    cps = db.CodicionPagos.Find(id);

                    db.CodicionPagos.Remove(cps);
                    db.SaveChanges();
                    db.Dispose();
                    return false;
                }


            }
            catch (Exception)
            {
                return true;
                throw;


            }

        }





        public static List<CondicionPagos> GetListaDescripcion(string aux)
        {
            List<CondicionPagos> lista = new List<CondicionPagos>();

            var db = new SistemaVentasDb();

            lista = db.CodicionPagos.Where(p => p.Descripcion == aux).ToList();

            return lista;

        }

        public static List<CondicionPagos> GetLista(int id)
        {
            List<CondicionPagos> lista = new List<CondicionPagos>();

            var db = new SistemaVentasDb();

            lista = db.CodicionPagos.Where(p => p.CondicionId == id).ToList();

            return lista;

        }

        public static List<CondicionPagos> GetLista()
        {
            List<CondicionPagos> lista = new List<CondicionPagos>();

            var db = new SistemaVentasDb();

            lista = db.CodicionPagos.ToList();

            return lista;


        }
       

    }
}
