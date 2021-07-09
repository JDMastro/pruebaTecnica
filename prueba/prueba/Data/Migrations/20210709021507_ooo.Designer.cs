﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using prueba.Data;

namespace prueba.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210709021507_ooo")]
    partial class ooo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("prueba.Models.Areas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("TrabajadoresId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasDatabaseName("Idx_descripcion_areas");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("prueba.Models.Empresas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Descripcion")
                        .IsUnique()
                        .HasDatabaseName("Idx_descripcion_empresa");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("prueba.Models.Trabajadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("AreasId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("EmpresasId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Salario")
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("AreasId");

                    b.HasIndex("EmpresasId");

                    b.HasIndex("Telefono")
                        .IsUnique()
                        .HasDatabaseName("Idx_telefono_trabajadores");

                    b.ToTable("Trabajadores");
                });

            modelBuilder.Entity("prueba.Models.Trabajadores", b =>
                {
                    b.HasOne("prueba.Models.Areas", "Areas")
                        .WithMany("Trabajadores")
                        .HasForeignKey("AreasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("prueba.Models.Empresas", null)
                        .WithMany("Trabajadores")
                        .HasForeignKey("EmpresasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Areas");
                });

            modelBuilder.Entity("prueba.Models.Areas", b =>
                {
                    b.Navigation("Trabajadores");
                });

            modelBuilder.Entity("prueba.Models.Empresas", b =>
                {
                    b.Navigation("Trabajadores");
                });
#pragma warning restore 612, 618
        }
    }
}
