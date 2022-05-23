﻿// <auto-generated />
using System;
using Catalog.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Catalog.DataAccess.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    partial class CatalogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Catalog.Entities.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoachsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfEstablishment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("NumberOfChampionsLeagueTitles")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfCupTitles")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfLeagueTitles")
                        .HasColumnType("int");

                    b.Property<string>("PresidentsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StadiumName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Clubs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoachsName = "Xavi Hernandez",
                            CountryId = 1,
                            Name = "Barcelona"
                        },
                        new
                        {
                            Id = 2,
                            CoachsName = "Carlo Ancelotti",
                            CountryId = 1,
                            Name = "Real Madrid"
                        },
                        new
                        {
                            Id = 3,
                            CoachsName = "Domènec Torrent",
                            CountryId = 4,
                            Name = "Galatasaray"
                        },
                        new
                        {
                            Id = 4,
                            CoachsName = "Ersun Yanal",
                            CountryId = 4,
                            Name = "Fenerbahçe"
                        },
                        new
                        {
                            Id = 5,
                            CoachsName = "Jürgen Klopp",
                            CountryId = 3,
                            Name = "liverpool"
                        });
                });

            modelBuilder.Entity("Catalog.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Spain"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 3,
                            Name = "England"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Turkey"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Italy"
                        });
                });

            modelBuilder.Entity("Catalog.Entities.Club", b =>
                {
                    b.HasOne("Catalog.Entities.Country", "Country")
                        .WithMany("Clubs")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Catalog.Entities.Country", b =>
                {
                    b.Navigation("Clubs");
                });
#pragma warning restore 612, 618
        }
    }
}
