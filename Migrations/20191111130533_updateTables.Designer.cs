﻿// <auto-generated />
using System;
using INPRO.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace INPRO.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191111130533_updateTables")]
    partial class updateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("INPRO.API.Models.Dci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DciCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DciName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dcis");
                });

            modelBuilder.Entity("INPRO.API.Models.Laboratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LaboratoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LaboratotyCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Laboratories");
                });

            modelBuilder.Entity("INPRO.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isMain")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("INPRO.API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Availible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conditioning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedDateTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DciId")
                        .HasColumnType("int");

                    b.Property<string>("Dosage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imported")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LaboratoryId")
                        .HasColumnType("int");

                    b.Property<string>("LastUpdatedTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PPA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PharmacologicalClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Psychotropic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ReferencePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Refundable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Removed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TherapeuticClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thermolabile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DciId");

                    b.HasIndex("LaboratoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("INPRO.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProfilId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("INPRO.API.Models.Photo", b =>
                {
                    b.HasOne("INPRO.API.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INPRO.API.Models.Product", b =>
                {
                    b.HasOne("INPRO.API.Models.Dci", null)
                        .WithMany("Products")
                        .HasForeignKey("DciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INPRO.API.Models.Laboratory", null)
                        .WithMany("Products")
                        .HasForeignKey("LaboratoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
