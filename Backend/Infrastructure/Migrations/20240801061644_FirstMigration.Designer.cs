﻿// <auto-generated />
using Infrastructure.Persistance.MSSqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DbContextMSSqlServer))]
    [Migration("20240801061644_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entity.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LongName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LongName = "Human Resources",
                            ShortName = "HR"
                        },
                        new
                        {
                            Id = 2,
                            LongName = "Finance",
                            ShortName = "FN"
                        },
                        new
                        {
                            Id = 3,
                            LongName = "Technology",
                            ShortName = "TE"
                        });
                });

            modelBuilder.Entity("Domain.Entity.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AnnualSalary")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsManager")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnnualSalary = 60000m,
                            DepartmentId = 1,
                            FirstName = "Bob",
                            IsManager = true,
                            LastName = "Jones"
                        },
                        new
                        {
                            Id = 2,
                            AnnualSalary = 80000m,
                            DepartmentId = 2,
                            FirstName = "Sarah",
                            IsManager = true,
                            LastName = "Jameson"
                        },
                        new
                        {
                            Id = 3,
                            AnnualSalary = 40000m,
                            DepartmentId = 2,
                            FirstName = "Douglas",
                            IsManager = false,
                            LastName = "Roberts"
                        },
                        new
                        {
                            Id = 4,
                            AnnualSalary = 30000m,
                            DepartmentId = 3,
                            FirstName = "Jane",
                            IsManager = false,
                            LastName = "Stevens"
                        });
                });

            modelBuilder.Entity("Domain.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CountryName")
                        .IsUnique()
                        .HasFilter("[CountryName] IS NOT NULL");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "Uzbekistan"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "India"
                        });
                });

            modelBuilder.Entity("Domain.Models.Dose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dosage")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dosage = 10,
                            Title = "мг"
                        },
                        new
                        {
                            Id = 2,
                            Dosage = 20,
                            Title = "мг"
                        },
                        new
                        {
                            Id = 3,
                            Dosage = 30,
                            Title = "мг"
                        },
                        new
                        {
                            Id = 4,
                            Dosage = 100,
                            Title = "мл"
                        },
                        new
                        {
                            Id = 5,
                            Dosage = 200,
                            Title = "мл"
                        },
                        new
                        {
                            Id = 6,
                            Dosage = 300,
                            Title = "мл"
                        });
                });

            modelBuilder.Entity("Domain.Models.DoseMedicine", b =>
                {
                    b.Property<int>("DoseId")
                        .HasColumnType("int");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.HasKey("DoseId", "MedicineId");

                    b.HasIndex("MedicineId");

                    b.ToTable("DoseMedicines");

                    b.HasData(
                        new
                        {
                            DoseId = 1,
                            MedicineId = 1
                        },
                        new
                        {
                            DoseId = 2,
                            MedicineId = 2
                        },
                        new
                        {
                            DoseId = 3,
                            MedicineId = 3
                        },
                        new
                        {
                            DoseId = 3,
                            MedicineId = 4
                        });
                });

            modelBuilder.Entity("Domain.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("ManufacturerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("ManufacturerName")
                        .IsUnique()
                        .HasFilter("[ManufacturerName] IS NOT NULL");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            ManufacturerAddress = "Address, address",
                            ManufacturerName = "NikaPharm"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            ManufacturerAddress = "Address, address",
                            ManufacturerName = "Gedeon"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            ManufacturerAddress = "Address, address",
                            ManufacturerName = "GSK"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 3,
                            ManufacturerAddress = "Address, address",
                            ManufacturerName = "Novartis"
                        });
                });

            modelBuilder.Entity("Domain.Models.Medform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Таблетки"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Раствор"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Капсула"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Капли"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Сироп"
                        });
                });

            modelBuilder.Entity("Domain.Models.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int>("MedformId")
                        .HasColumnType("int");

                    b.Property<string>("TradeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("MedformId");

                    b.ToTable("Medicines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://catalog.milliykatalogi.uz/s3/300x200/d907d480-1123-7c71-e0df-3d981a6960ff.jpg",
                            InterName = "Ekvator",
                            ManufacturerId = 1,
                            MedformId = 2,
                            TradeName = "Экватор"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://catalog.milliykatalogi.uz/s3/300x200/d907d480-1123-7c71-e0df-3d981a6960ff.jpg",
                            InterName = "Paracetamol",
                            ManufacturerId = 2,
                            MedformId = 1,
                            TradeName = "Парацетамол"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://catalog.milliykatalogi.uz/s3/300x200/d907d480-1123-7c71-e0df-3d981a6960ff.jpg",
                            InterName = "Trimol",
                            ManufacturerId = 1,
                            MedformId = 2,
                            TradeName = "Тримол"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://catalog.milliykatalogi.uz/s3/300x200/d907d480-1123-7c71-e0df-3d981a6960ff.jpg",
                            InterName = "Acvad",
                            ManufacturerId = 1,
                            MedformId = 2,
                            TradeName = "Аквад"
                        });
                });

            modelBuilder.Entity("Domain.Models.MedicineSubstance", b =>
                {
                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("SubstanceId")
                        .HasColumnType("int");

                    b.HasKey("MedicineId", "SubstanceId");

                    b.HasIndex("SubstanceId");

                    b.ToTable("MedicineSubstances");

                    b.HasData(
                        new
                        {
                            MedicineId = 1,
                            SubstanceId = 1
                        },
                        new
                        {
                            MedicineId = 2,
                            SubstanceId = 2
                        },
                        new
                        {
                            MedicineId = 3,
                            SubstanceId = 3
                        },
                        new
                        {
                            MedicineId = 4,
                            SubstanceId = 3
                        });
                });

            modelBuilder.Entity("Domain.Models.Substance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InternationalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Substances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InternationalName = "аланин",
                            TradeName = "аланин"
                        },
                        new
                        {
                            Id = 2,
                            InternationalName = "глицин",
                            TradeName = "глицин"
                        },
                        new
                        {
                            Id = 3,
                            InternationalName = "цетримид",
                            TradeName = "цетримид"
                        },
                        new
                        {
                            Id = 4,
                            InternationalName = "тофизопам",
                            TradeName = "тофизопам"
                        },
                        new
                        {
                            Id = 5,
                            InternationalName = "сорбитол",
                            TradeName = "сорбитол"
                        });
                });

            modelBuilder.Entity("Domain.Models.DoseMedicine", b =>
                {
                    b.HasOne("Domain.Models.Dose", "Dose")
                        .WithMany()
                        .HasForeignKey("DoseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Medicine", "Medicine")
                        .WithMany("DoseMedicines")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dose");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("Domain.Models.Manufacturer", b =>
                {
                    b.HasOne("Domain.Models.Country", "Country")
                        .WithMany("Manufacturers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Domain.Models.Medicine", b =>
                {
                    b.HasOne("Domain.Models.Manufacturer", "Manufacturer")
                        .WithMany("Medicine")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Medform", "Medform")
                        .WithMany()
                        .HasForeignKey("MedformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");

                    b.Navigation("Medform");
                });

            modelBuilder.Entity("Domain.Models.MedicineSubstance", b =>
                {
                    b.HasOne("Domain.Models.Medicine", "Medicine")
                        .WithMany("MedicineSubstances")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Substance", "Substance")
                        .WithMany()
                        .HasForeignKey("SubstanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Substance");
                });

            modelBuilder.Entity("Domain.Models.Country", b =>
                {
                    b.Navigation("Manufacturers");
                });

            modelBuilder.Entity("Domain.Models.Manufacturer", b =>
                {
                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("Domain.Models.Medicine", b =>
                {
                    b.Navigation("DoseMedicines");

                    b.Navigation("MedicineSubstances");
                });
#pragma warning restore 612, 618
        }
    }
}