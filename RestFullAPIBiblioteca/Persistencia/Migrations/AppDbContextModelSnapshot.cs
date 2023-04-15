﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia.Contexto;

#nullable disable

namespace Persistencia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Entidades.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("Creadopor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomcategoria")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("Dominio.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Creado")
                        .HasColumnType("datetime2");

                    b.Property<string>("Creadopor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Existencias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UltimaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UltimaModificacionPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<double>("precioCompra")
                        .HasColumnType("float");

                    b.Property<string>("producto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("categoriaId");

                    b.ToTable("Productos", (string)null);
                });

            modelBuilder.Entity("Dominio.Entidades.Producto", b =>
                {
                    b.HasOne("Dominio.Entidades.Categorias", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
