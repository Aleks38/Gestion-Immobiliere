using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Exo.Data.Models;
using WPF_TP.Data.Models;

namespace WPF_TP.Data.DAL
{
    internal class ImoContext : DbContext
    {
        public DbSet<Biens> Biens { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Intervention> Intervention { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Pret> Prets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost; Database=GestionImmobiliere; Username=postgres; Password=root");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Habitations>().ToTable("Habitations");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Appartement");
        }

        private static ImoContext instance;

        public static ImoContext getInstance()
        {
            if (instance == null)
            {
                instance = new ImoContext();
            }

            return instance;
        }
    }
}
