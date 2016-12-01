using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;
using SistemaDeVentas.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DAL
{
    public class SistemaVentasDb : DbContext
    {


        public SistemaVentasDb() : base("name=ConStr")
        {

        }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
      
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }

        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }

        public virtual DbSet<Empleados> Empleados { get; set; }

        public virtual DbSet<CondicionPagos> CodicionPagos { get; set; }

        public virtual DbSet<Categorias> Categorias { get; set; }

        public virtual DbSet<Ventas> Ventas { get; set; }

        public virtual DbSet<Articulos> Articulos { get; set; }

        
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ventas>()
                 .HasMany<Articulos>(a => a.Articulos)
                 .WithMany(v => v.Ventas)
                 .Map(ge =>
                 {
                     ge.MapLeftKey("ArticuloId");
                     ge.MapRightKey("VentaId");
                     ge.ToTable("DetalleVentas");
                 });
            
            


        }

    }
}



   
