﻿// <auto-generated />
using System;
using FilmYorum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmYorum.Migrations
{
    [DbContext(typeof(FilmContext))]
    partial class FilmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilmYorum.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FilmAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("FilmYili")
                        .HasColumnType("int");

                    b.Property<string>("ImbdPuan")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("FilmYorum.FilmSinifi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TurAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TurID")
                        .HasColumnType("int");

                    b.Property<int>("filmSinifiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("filmSinifiId");

                    b.ToTable("FilmSiniflari");
                });

            modelBuilder.Entity("FilmYorum.FilmSinifi", b =>
                {
                    b.HasOne("FilmYorum.FilmSinifi", "filmSinifi")
                        .WithMany()
                        .HasForeignKey("filmSinifiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("filmSinifi");
                });
#pragma warning restore 612, 618
        }
    }
}
