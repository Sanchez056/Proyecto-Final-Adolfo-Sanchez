using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using SistemaDeVentas.Entidades;

namespace BLL
{
   public class TiposUsuariosBLL
    {

        TipoUsuarios usuario = new TipoUsuarios();
        public static bool Insertars(TipoUsuarios t)
        {
            //  bool retorna = false;

            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.TipoUsuarios.Add(t);
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
        public static bool Modificard(int id, TipoUsuarios tip)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    TipoUsuarios t = db.TipoUsuarios.Find(id);
                    t.Detalle = tip.Detalle;

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


        public static TipoUsuarios Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.TipoUsuarios.Find(id);


        }

        public static bool Eliminar(int id)
        {
            
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    TipoUsuarios t = new TipoUsuarios();
                    t = db.TipoUsuarios.Find(id);

                    db.TipoUsuarios.Remove(t);
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
        public static List<TipoUsuarios> GetLista()
        {
            List<TipoUsuarios> lista = new List<TipoUsuarios>();

            var db = new SistemaVentasDb();

            lista = db.TipoUsuarios.ToList();

            return lista;


        }
        public static List<TipoUsuarios> GetLista(int tipoId)
        {
            List<TipoUsuarios> lista = new List<TipoUsuarios>();

            var db = new SistemaVentasDb();

            lista = db.TipoUsuarios.Where(p => p.TipoUsuarioId == tipoId).ToList();

            return lista;

        }
        public static List<TipoUsuarios> GetListaDetalle(string detalle)
        {
            List<TipoUsuarios> lista = new List<TipoUsuarios>();

            var db = new SistemaVentasDb();

            lista = db.TipoUsuarios.Where(p => p.Detalle == detalle).ToList();

            return lista;

        }
    }
}
