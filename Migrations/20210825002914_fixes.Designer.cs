﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TarjetasApp.Data;

namespace TarjetasApp.Migrations
{
    [DbContext(typeof(TarjetasContext))]
    [Migration("20210825002914_fixes")]
    partial class fixes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TarjetasApp.Models.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdPersona");

                    b.ToTable("Persona");

                    b.HasData(
                        new
                        {
                            IdPersona = 1,
                            Apellido = "Asis",
                            DNI = "36897456",
                            Direccion = "Calle 123",
                            Nombre = "Alex"
                        });
                });

            modelBuilder.Entity("TarjetasApp.Models.Tarjeta", b =>
                {
                    b.Property<int>("IdTarjeta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<long>("Limite")
                        .HasColumnType("bigint");

                    b.Property<int>("Marca")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Tasa")
                        .HasColumnType("float");

                    b.Property<string>("Titular")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("IdTarjeta");

                    b.HasIndex("IdPersona");

                    b.ToTable("Tarjeta");

                    b.HasData(
                        new
                        {
                            IdTarjeta = 1,
                            IdPersona = 1,
                            Limite = 100000L,
                            Marca = 2,
                            Nombre = "Alex",
                            Numero = "00000000",
                            Tasa = 0.80000000000000004,
                            Titular = "Alex",
                            Vencimiento = new DateTime(2021, 8, 24, 21, 29, 14, 115, DateTimeKind.Local).AddTicks(136)
                        });
                });

            modelBuilder.Entity("TarjetasApp.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1,
                            Nombre = "Alex",
                            NombreUsuario = "Alex",
                            Password = "Asis"
                        });
                });

            modelBuilder.Entity("TarjetasApp.Models.Tarjeta", b =>
                {
                    b.HasOne("TarjetasApp.Models.Persona", "Persona")
                        .WithMany("Tarjetas")
                        .HasForeignKey("IdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("TarjetasApp.Models.Persona", b =>
                {
                    b.Navigation("Tarjetas");
                });
#pragma warning restore 612, 618
        }
    }
}