﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaSaude.Data;

#nullable disable

namespace SistemaSaude.Migrations
{
    [DbContext(typeof(SistemaSaudeDbContext))]
    [Migration("20250401202054_initalMigration")]
    partial class initalMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.14");

            modelBuilder.Entity("SistemaSaude.Model.Doctor", b =>
                {
                    b.Property<string>("CRM")
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CRM");

                    b.ToTable("Medicos");
                });
#pragma warning restore 612, 618
        }
    }
}
