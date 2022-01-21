using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TarjetasApp.Helpers;
using TarjetasApp.Models;

namespace TarjetasApp.Data
{
    public class TarjetasContext : DbContext
    {
        private ITasaCalculator tasaCalculator;

        public TarjetasContext(DbContextOptions<TarjetasContext> options, ITasaCalculator tasaCalculator)
            : base(options)
        {
            this.tasaCalculator = tasaCalculator;
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarjeta> Tarjeta { get; set; }
        public DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasData(new Usuario()
            {
                IdUsuario = 1,
                Nombre = "Alex",
                NombreUsuario = "Alex",
                Password = "asis"
            });

            modelBuilder.Entity<Tarjeta>().HasData(new Tarjeta()
            {
                IdTarjeta = 1,
                IdPersona = 1,
                Nombre = "Alex",
                Numero = "00000000",
                Limite = 100000,
                Marca = Marca.PERE,
                Tasa = tasaCalculator.CalcularTasaPorcentual(Marca.PERE, DateTime.Now),
                Titular = "Alex",
                Vencimiento = DateTime.Now
            });

            modelBuilder.Entity<Persona>().HasData(new Persona()
            {
                IdPersona = 1,
                Nombre = "Alex",
                Apellido = "asis",
                Direccion = "Osvaldo Cruz",
                DNI = "36869485"
            });
        }
    }
}
