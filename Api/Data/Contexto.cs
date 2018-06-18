using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Api.Models;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }

        public Contexto() : base("Name=Azure")
        {
            Database.SetInitializer<Contexto>(
                new CreateDatabaseIfNotExists<Contexto>());
            Database.Initialize(false);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//
//            modelBuilder.Entity<Estado>().
//                HasRequired<Pais>(s => s.Pais)
//                .WithMany(g => g.Estados)
//                .HasForeignKey<int>(s => s.PaisId);
//
//            modelBuilder.Entity<Amigo>().HasRequired<Pais>(s => s.Pais);
//            modelBuilder.Entity<Amigo>().HasRequired<Estado>(s => s.Estado);

                


            base.OnModelCreating(modelBuilder);
        }

    }
}