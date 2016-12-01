using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;


namespace BLL
{
   public class ProveedorBLL
    {
        Proveedores proveedores = new Proveedores();

        public static bool Insertar(Proveedores p)
        {
           /// bool retorna = false;
           
            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Proveedores.Add(p);
                    db.SaveChanges();
                    //db.Dispose();
                    // retorna = true;
                    return true;
                }


            }
            catch (Exception e)
            {
                return false;
                throw e;

            }
           /// return retorna;

        }
        public static bool Modificar(int id, Proveedores prov)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    Proveedores p = db.Proveedores.Find(id);
                    p.NombreProveedor = prov.NombreProveedor;
                    p.Telefono = prov.Telefono;
                    p.Ciudad = prov.Ciudad;
                    p.Correo = prov.Correo;
                    p.Direccion = prov.Direccion;
                    p.Fax = prov.Fax;

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


        public static Proveedores Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Proveedores.Find(id);


        }

        public static bool Eliminar(int id)
        {
            //bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    Proveedores p = new Proveedores();
                    p = db.Proveedores.Find(id);

                    db.Proveedores.Remove(p);
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


        public static List<Proveedores> GetLista()
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.ToList();

            return lista;


        }

        public static List<Proveedores> GetLista(int proveedorId)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.Where(p => p.ProveedorId == proveedorId).ToList();

            return lista;

        }



        public static List<Proveedores> GetListaNombreProveedor(string aux)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.Where(p => p.NombreProveedor == aux).ToList();

            return lista;

        }

       

       
        public static List<Proveedores> GetListaFecha(DateTime aux)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.Where(p => p.FechaIngreso == aux).ToList();

            return lista;

        }
        public static List<Proveedores> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Proveedores> lista = new List<Proveedores>();

            var db = new SistemaVentasDb();

            lista = db.Proveedores.Where(p => p.FechaIngreso >= Desde && p.FechaIngreso <= Hasta).ToList();

            return lista;

        }



    }
}

