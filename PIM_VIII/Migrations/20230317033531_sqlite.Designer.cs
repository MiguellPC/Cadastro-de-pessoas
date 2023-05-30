﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PIM_VIII.Data;

#nullable disable

namespace PIM_VIII.Migrations
{
    [DbContext(typeof(PIM_VIIIContext))]
    [Migration("20230317033531_sqlite")]
    partial class sqlite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("PIM_VIII.Models.Endereco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("Cep")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("PIM_VIII.Models.Pessoa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Cpf")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("enderecoID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("telefonesID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("enderecoID");

                    b.HasIndex("telefonesID");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("PIM_VIII.Models.Telefone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ddd")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<int>("tipoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("tipoID");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("PIM_VIII.Models.TipoTelefone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("TipoTelefone");
                });

            modelBuilder.Entity("PIM_VIII.Models.Pessoa", b =>
                {
                    b.HasOne("PIM_VIII.Models.Endereco", "endereco")
                        .WithMany("pessoa")
                        .HasForeignKey("enderecoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PIM_VIII.Models.Telefone", "telefones")
                        .WithMany()
                        .HasForeignKey("telefonesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("endereco");

                    b.Navigation("telefones");
                });

            modelBuilder.Entity("PIM_VIII.Models.Telefone", b =>
                {
                    b.HasOne("PIM_VIII.Models.TipoTelefone", "tipo")
                        .WithMany()
                        .HasForeignKey("tipoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipo");
                });

            modelBuilder.Entity("PIM_VIII.Models.Endereco", b =>
                {
                    b.Navigation("pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}