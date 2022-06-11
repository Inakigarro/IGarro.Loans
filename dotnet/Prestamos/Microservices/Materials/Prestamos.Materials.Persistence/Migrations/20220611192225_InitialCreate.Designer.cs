﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prestamos.Materials.Persistence;

#nullable disable

namespace Prestamos.Materials.Persistence.Migrations
{
    [DbContext(typeof(MaterialsDbContext))]
    [Migration("20220611192225_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Prestamos.Materials.Domain.Entities.Material", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeCorrelationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CorrelationId");

                    b.HasIndex("TypeCorrelationId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Prestamos.Materials.Domain.Entities.MaterialType", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CorrelationId");

                    b.ToTable("MaterialTypes");
                });

            modelBuilder.Entity("Prestamos.Materials.Domain.Entities.Material", b =>
                {
                    b.HasOne("Prestamos.Materials.Domain.Entities.MaterialType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeCorrelationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
