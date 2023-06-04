﻿// <auto-generated />
using System.Text.Json.Nodes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Panda.SOS.Infra.Context;

#nullable disable

namespace Panda.SOS.Infra.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20230529012138_drop_column_description")]
    partial class drop_column_description
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Panda.SOS.Domain.Entities.Companies", b =>
                {
                    b.Property<string>("Cnpj")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Cnpj");

                    b.ToTable("Companies", (string)null);
                });

            modelBuilder.Entity("Panda.SOS.Domain.Entities.PhoneCompany", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Cnpj")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<JsonArray>("Parts")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("parts");

                    b.HasKey("Id", "Cnpj");

                    b.HasIndex("Cnpj");

                    b.ToTable("PhoneCompany", (string)null);
                });

            modelBuilder.Entity("Panda.SOS.Domain.Entities.Phones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brands")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("brands");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Phones", (string)null);
                });

            modelBuilder.Entity("Panda.SOS.Domain.Entities.PhoneCompany", b =>
                {
                    b.HasOne("Panda.SOS.Domain.Entities.Companies", "Companies")
                        .WithMany()
                        .HasForeignKey("Cnpj")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Panda.SOS.Domain.Entities.Phones", "Phones")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companies");

                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}