using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Entidades;
namespace BLL
{
   public  class ClientesBLL
    {
        Clientes cliente= new Clientes();

        public static bool Insertar(Clientes c)
        {
           // bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {

                    db.Clientes.Add(c);
                    db.SaveChanges();
                    db.Dispose();
                    // retorna = true;
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

        public static Clientes Buscar(int id)
        {
            var db = new SistemaVentasDb();

            return db.Clientes.Find(id);


        }
        public static Clientes BuscarNombre(string nombre )
        {
            var db = new SistemaVentasDb();

            return db.Clientes.Find(nombre);


        }
        public static bool Modificar(int id,Clientes cli)
        {
            bool retorno = false;
            try
            {
                using (var db = new SistemaVentasDb())
                {
                    Clientes c = db.Clientes.Find(id);
                    c.Nombre = cli.Nombre;
                    c.Celular = cli.Celular;
                    c.Ciudad = cli.Ciudad;
                    c.Direccion = cli.Direccion;
                    c.Cedula = cli.Cedula;
                    c.Sexo = cli.Sexo;
                    c.Telefono = cli.Telefono;

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





        public static bool Eliminar(int id)
        {
            //bool retorna = false;
            try
            {

                using (var db = new SistemaVentasDb())
                {
                    Clientes c = new Clientes();
                    c = db.Clientes.Find(id);

                    db.Clientes.Remove(c);
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

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.ToList();

            return lista;


        }

        public static List<Clientes> GetLista(int clienteId)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.ClienteId == clienteId).ToList();

            return lista;

        }



        public static List<Clientes> GetListaNombreCliente(string aux)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.Nombre == aux).ToList();

            return lista;

        }

       

        public static List<Clientes> GetListaSexo(string aux)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.Sexo == aux).ToList();

            return lista;

        }

        public static List<Clientes> GetListaCedula(string aux)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.Cedula == aux).ToList();

            return lista;

        }
        public static List<Clientes> GetListaFecha(DateTime aux)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.Fecha == aux).ToList();

            return lista;

        }
        public static List<Clientes> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Clientes> lista = new List<Clientes>();

            var db = new SistemaVentasDb();

            lista = db.Clientes.Where(p => p.Fecha >= Desde && p.Fecha <= Hasta).ToList();

            return lista;

        }
    }
}
