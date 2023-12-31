﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt_MVC.Models;

#nullable disable

namespace Projekt_MVC.Migrations
{
    [DbContext(typeof(DB_Context))]
    [Migration("20230616154829_nowa4")]
    partial class nowa4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projekt_MVC.Models.Enjoy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdKid")
                        .HasColumnType("int");

                    b.Property<string>("Idea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Enjoy");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdKid")
                        .HasColumnType("int");

                    b.Property<string>("Messag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Projekt_MVC.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Homework")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdKid")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("IdKid")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Thing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdKid")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("When")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Enjoy", b =>
                {
                    b.HasOne("Projekt_MVC.Models.Person", null)
                        .WithMany("Enjoy")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Message", b =>
                {
                    b.HasOne("Projekt_MVC.Models.Person", null)
                        .WithMany("Message")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Projekt_MVC.Models.School", b =>
                {
                    b.HasOne("Projekt_MVC.Models.Person", null)
                        .WithMany("School")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Shop", b =>
                {
                    b.HasOne("Projekt_MVC.Models.Person", null)
                        .WithMany("Shop")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Work", b =>
                {
                    b.HasOne("Projekt_MVC.Models.Person", null)
                        .WithMany("Work")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Projekt_MVC.Models.Person", b =>
                {
                    b.Navigation("Enjoy");

                    b.Navigation("Message");

                    b.Navigation("School");

                    b.Navigation("Shop");

                    b.Navigation("Work");
                });
#pragma warning restore 612, 618
        }
    }
}
