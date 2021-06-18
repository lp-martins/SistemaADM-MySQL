﻿// <auto-generated />
using System;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entidades.Balancete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeDaConta")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("NumeroDaConta")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.ToTable("Balancetes");
                });

            modelBuilder.Entity("Dominio.Entidades.Lancamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Credito")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("DATE");

                    b.Property<string>("Debito")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.Property<string>("PlanoDeContaID")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ReciboFiscal")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.HasIndex("Credito");

                    b.ToTable("Lancamentos");
                });

            modelBuilder.Entity("Dominio.Entidades.PlanoDeConta", b =>
                {
                    b.Property<string>("NumeroDaConta")
                        .HasColumnType("varchar(12)");

                    b.Property<int?>("BalanceteId")
                        .HasColumnType("int");

                    b.Property<string>("NomeDaConta")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("NumeroDaConta");

                    b.HasIndex("BalanceteId");

                    b.ToTable("PlanoDeContas");
                });

            modelBuilder.Entity("Dominio.Entidades.Lancamento", b =>
                {
                    b.HasOne("Dominio.Entidades.PlanoDeConta", "PlanoDeConta")
                        .WithMany("Lancamentos")
                        .HasForeignKey("Credito")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Entidades.PlanoDeConta", b =>
                {
                    b.HasOne("Dominio.Entidades.Balancete", "Balancete")
                        .WithMany("PlanoDeContas")
                        .HasForeignKey("BalanceteId");
                });
#pragma warning restore 612, 618
        }
    }
}
